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

    public void EnqueueObject(GameObject obj) // ������Ʈ�� �ִ� ���
    {
        objQueue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject DequeueObject() // ������Ʈ�� �̴� ���
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


                GameObject obj = DequeueObject(); // Ǯ���� ������Ʈ�� �̾Ƽ� ���
                obj.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
            }
        }

        // ������ ������Ʈ���� ����ϴ� ���
        // StudyObjectPool.Instance.EnqueueObject(gameObject);
    }

}
