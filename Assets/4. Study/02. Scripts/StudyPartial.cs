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
//    private int number; // 변수 이름 동일 x

//    private void Start() // 함수 이름 동일 X
//    {

//    }

//    void MethodB()
//    {
//        Debug.Log("MethodB");
//    }

//}