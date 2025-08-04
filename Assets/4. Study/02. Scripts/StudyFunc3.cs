using System;
using UnityEngine;

public class StudyFunc3 : MonoBehaviour
{
    public int hp = 100;

    public Func<int> GetHp;

    public Func<float, float> GetRemainHp;

    public Func<string> GetAction;

    private void Start()
    {
        GetHp= () => hp; // ü��

        GetRemainHp = (float dmg) => hp - dmg; // ������ ���� �� ü��

        GetAction = () =>
        {
            if (GetHp() > 50)
                return "����";
            else if (GetHp() > 20)
                return "����";

            else
                return "����";
        };
    }
}
