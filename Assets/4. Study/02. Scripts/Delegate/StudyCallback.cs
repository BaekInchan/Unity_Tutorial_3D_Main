using System;
using System.Collections;
using UnityEngine;

public class StudyCallback : MonoBehaviour
{
    public static Action bombAction;

    private void OnEnable()
    {
        bombAction += () =>
        {
            BombExplosition();
            BombDamage();
            BombEffect();
        };
        
    }

    IEnumerator Start()
    {
        Debug.Log("��ź Ÿ�̸� ����");
        yield return new WaitForSeconds(3f);

        bombAction?.Invoke();
    }

    private void BombExplosition()
    {
        Debug.Log("���� ����");
    }

    private void BombDamage()
    {
        Debug.Log("���� ������ ����");
    }

    private void BombEffect()
    {
        Debug.Log("���� ����Ʈ ����");
    }

}
