using UnityEngine;

public class StudyEvent : MonoBehaviour
{
    public delegate void InputKeyHandler(string msg);
    // event: '외부'에서 delegate 실행 방지
    public event InputKeyHandler onInputKey;

    void Start()
    {
        onInputKey += delegate 
        {
            Event1("Hello Unity");
            Event2();
            Event3();
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            onInputKey?.Invoke("Hello Unity");
    }

    private void InputKeyEvent(string msg)
    {
        Debug.Log(msg);
    }

    private void Event1(string msg)
    {
        Debug.Log(msg);
    }
    private void Event2()
    {
        Debug.Log("Event2");
    }

    private void Event3()
    {
        Debug.Log("Event3");
    }
}