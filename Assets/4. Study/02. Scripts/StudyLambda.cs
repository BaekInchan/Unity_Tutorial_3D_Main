using UnityEngine;
using UnityEngine.UI;

public class StudyLambda : MonoBehaviour
{
    public delegate void MyDelegate(string s);
    public MyDelegate myDelegate;

    public Button button;

    private void Start()
    {
        // ��ư�� 1���� ����� ����ϴ� ���
        button.onClick.AddListener(ButtonEvent);
        

        //�͸� �Լ��� ���� ����� ����ϴ� ���
        button.onClick.AddListener(delegate
        {
            ButtonEvent();
            OnLog("Lambda");
        });

        // ���ٽ����� 1���� ����� ����ϴ� ��� (�Ű����� ��밡��)
        button.onClick.AddListener(() => OnLog("Hello"));

        // ���ٽ����� ��������� ����ϴ� ���
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
