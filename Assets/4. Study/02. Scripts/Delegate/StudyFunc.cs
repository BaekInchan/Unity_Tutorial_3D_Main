using System;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    public enum Buff { A, B, C }
    public Buff buff;


    public Buff currentBuff;
    public float currentDmg;

    // �������� �Ű������� ���� �� �ְ� ��ȯŸ�� �ִ� ���

    // ���������� Func<�Ű����� ,�Ű�����, ... , ��ȯŸ��> ������
    public Func<Buff, float, float> myFunc;
    public Func<string, int, float, float, string> myFunc2;

    private void Start()
    {
        myFunc?.Invoke(currentBuff, currentDmg);

    }

    private int AddMethod(int n1, int n2)
    {
        return n1 + n2;
    }

    private int MinusMethod(int n1, int n2)
    {
        return n1 - n2;
    }

    private float CalculationDamage(Buff buff, float dmg)
    {
        int result = 0;
        switch (buff)
        {
            case Buff.A:
                result = 10;
                break;
            case Buff.B:
                result = -20;
                break;
            case Buff.C:
                result = 100;
                break;
        }

        return dmg * result;
    }
}
