using UnityEngine;


public class ParentClass : MonoBehaviour
{
    public virtual void Method() // ���� �Լ�
    {
        Debug.Log("Method");
    }
}

public class StudySealled : ParentClass
{
    public sealed override void Method() // �������̵��� �Լ�
    {
        base.Method(); // �θ� Ŭ������ �Լ� ����� �������� ���
        Debug.Log("Override Method");
    }

}