using UnityEngine;
using UnityEngine.UI;

public class StudyLambda : MonoBehaviour
{
    public delegate void MyDelegate(string s);
    public MyDelegate myDelegate;

    public Button button;

    private void Start()
    {
        // 버튼에 1개의 기능을 등록하는 방법
        button.onClick.AddListener(ButtonEvent);
        

        //익명 함수로 여러 기능을 등록하는 방법
        button.onClick.AddListener(delegate
        {
            ButtonEvent();
            OnLog("Lambda");
        });

        // 람다식으로 1개의 기능을 등록하는 방법 (매개변수 사용가능)
        button.onClick.AddListener(() => OnLog("Hello"));

        // 람다식으로 여러기능을 등록하는 방법
        button.onClick.AddListener(() =>
        {
            ButtonEvent();
            OnLog("Lambda");
        });
    }

    private void ButtonEvent()
    {
        Debug.Log("Button Event");
    }

    private void OnLog(string msg)
    {
        Debug.Log("Hello Unity");
    }
}
