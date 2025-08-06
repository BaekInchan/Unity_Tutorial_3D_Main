using UnityEngine;
using UnityEngine.Pool;

public class StudyObjectPool2 : StudyGenericSingleton<StudyObjectPool2>
{
    public ObjectPool<GameObject> objPool;
    public GameObject objPrefab;

    private void Awake()
    {
        objPool = new ObjectPool<GameObject>(CreateObject, GetObject, ReleaseObject);
    }

    private GameObject CreateObject()
    {
        GameObject obj = Instantiate(objPrefab, transform);
        obj.SetActive(false);

        return obj;
    }

    private void GetObject(GameObject obj)
    {
        Debug.Log("Ǯ���� ������Ʈ �̴� ���");
        obj.SetActive(true);
    }

    private void ReleaseObject(GameObject obj)
    {
        Debug.Log("Ǯ�� ������Ʈ�� �ִ� ���");
        obj.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject obj = objPool.Get();
        }

        // ������ ������Ʈ���� ����ϴ� ���
        // StudyObjectPool2.Instance.objPool.Release(gameObject);
    }
}
