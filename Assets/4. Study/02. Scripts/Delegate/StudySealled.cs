using UnityEngine;


public class ParentClass : MonoBehaviour
{
    public virtual void Method() // 가상 함수
    {
        Debug.Log("Method");
    }
}

public class StudySealled : ParentClass
{
    public sealed override void Method() // 오버라이드한 함수
    {
        base.Method(); // 부모 클래스의 함수 기능을 가져오는 방법
        Debug.Log("Override Method");
    }

}