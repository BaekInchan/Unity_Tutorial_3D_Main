using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StudyUnityEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent onUnityEvent;



    private void Start()
    {
        //onUnityEvent += MethodA;

        onUnityEvent.AddListener(delegate
        {
            Debug.Log("Hello");
            Debug.Log("Unity");
            Debug.Log("World");
            MethodA();

            PrintLog("Hello Unity");
        });
            

        
    }


    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            onUnityEvent?.Invoke();
        }
    }
    private void MethodA()
    {
        Debug.Log("MethodA");
    }
    

    private void PrintLog(string msg)
    {
        Debug.Log(msg);
    }
}
