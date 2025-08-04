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
        Debug.Log("긴급 정지 실행");
    }

}
