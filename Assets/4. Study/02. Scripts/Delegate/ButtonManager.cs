using System;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public static Action emergencyStopButton;

    private void Start()
    {
        emergencyStopButton += StopMessage;
    }

    private void StopMessage()
    {
        Debug.Log("��� ���� ����");
    }

}
