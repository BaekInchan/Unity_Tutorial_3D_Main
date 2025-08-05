using System;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    public enum Buff { A, B, C }
    public Buff buff;


    public Buff currentBuff;
    public float currentDmg;

    // 여러개의 매개변수를 넣을 수 있고 반환타입 있는 경우

    // 접근제한자 Func<매개변수 ,매개변수, ... , 반환타입> 변수명
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
