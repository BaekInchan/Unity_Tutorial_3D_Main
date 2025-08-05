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
        GetHp= () => hp; // Ã¼·Â

        GetRemainHp = (float dmg) => hp - dmg; // µ¥¹ÌÁö ¹ÞÀº ÈÄ Ã¼·Â

        GetAction = () =>
        {
            if (GetHp() > 50)
                return "°ø°Ý";
            else if (GetHp() > 20)
                return "±¤Æø";
            else if (GetHp() > 0)
                return "µµ¸Á";

            else
                return "Á×À½";
        };
    }
}
