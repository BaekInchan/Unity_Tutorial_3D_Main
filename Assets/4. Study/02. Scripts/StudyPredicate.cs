using System;
using UnityEngine;

public class StudyPredicate : MonoBehaviour
{
    // ���� ������ Predicate<�Ű�����> ������
    public Predicate<int> myPredicate;

    // �Ű����� �Ѱ��� ��� ����

    public int level = 10;

    private void Start()
    {
        myPredicate = n => n <= 10;
        string msg = myPredicate(level) ? "�ʺ��� ����� ���� ����" : "�ʺ��� ����� ���� �Ұ���" ;
                 
        Debug.Log(msg);

        
    }

}
