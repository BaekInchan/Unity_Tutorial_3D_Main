using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class StudyUnityAction : MonoBehaviour
{
    public UnityAction unityAction;
    public Button button;


    void Start()
    {
        unityAction += MethodA;
        button = GetComponent<Button>();

        button.onClick.AddListener(MethodA);

        button.onClick.AddListener(() =>
        {
            Debug.Log("Hello");
            MethodA();
        });
    }

    private void MethodA()
    {
        Debug.Log("MethodA");
    }

    //public void GetScore2()
    //{
    //    score = 10;
    //}

    //public void GetScore()
    //{
    //    int score = 10;

    //}

}
