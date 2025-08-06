using System.Collections.Generic;
using UnityEngine;

public class StudyObjectPool : StudyGenericSingleton<StudyObjectPool>
{
    public Queue<GameObject> objQueue = new Queue<GameObject>();
    public GameObject objPrefab;

    public int poolSize = 500;

    private void Start()
    {
        CreateObject();
    }

    private void CreateObject()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject newObj = Instantiate(objPrefab, transform);
            EnqueueObject(newObj);
        }
    }

    public void EnqueueObject(GameObject obj) // 오브젝트를 넣는 기능
    {
        objQueue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject DequeueObject() // 오브젝트를 뽑는 기능
    {
        GameObject obj = objQueue.Dequeue();

        return obj;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (objQueue.Count > 0)
            {
                if (objQueue.Count < 10)
                    CreateObject();


                GameObject obj = DequeueObject(); // 풀에서 오브젝트를 뽑아서 사용
                obj.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            }
        }

        // 생성된 오브젝트에서 사용하는 기능
        // StudyObjectPool.Instance.EnqueueObject(gameObject);
    }

}
