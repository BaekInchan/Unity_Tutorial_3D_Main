using UnityEngine;

public partial class StudyPartial : MonoBehaviour
{
    private int number;


    private void Start()
    {
        MethodA();
        MethodB();
    }

    void MethodA()
    {
        Debug.Log("MethodA");
    }

}

//public partial class StudyPartial : MonoBehaviour
//{
//    private int number; // ���� �̸� ���� x

//    private void Start() // �Լ� �̸� ���� X
//    {

//    }

//    void MethodB()
//    {
//        Debug.Log("MethodB");
//    }

//}