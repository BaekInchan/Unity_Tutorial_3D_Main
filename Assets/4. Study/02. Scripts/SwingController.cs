using System;
using System.Collections;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    private Animator anim;

    public Action onStartSwing;
    public Action onEndSwing;

    private bool isSwing;

    private void Start()
    {
        anim = GetComponent<Animator>();

        onStartSwing += SwingStart;
        onEndSwing += SwingEnd;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isSwing)
            {
                StartCoroutine(SwingRoutine(onStartSwing, onEndSwing));
            }
        }
    }
    public IEnumerator SwingRoutine(Action action1, Action action2)
    {
        isSwing = true;        
        anim.SetTrigger("Swing");
        action1.Invoke();

        //float animLength = anim.GetCurrentAnimatorClipInfo(0).Length;

        yield return new WaitForSeconds(0.5f);

        

        action2?.Invoke();
        isSwing = false;
    }

    private void SwingStart()
    {
        Debug.Log("Ω∫¿Æ Ω√¿€");
    }
    private void SwingEnd()
    {
        Debug.Log("Ω∫¿Æ ¡æ∑·");
    }
}
