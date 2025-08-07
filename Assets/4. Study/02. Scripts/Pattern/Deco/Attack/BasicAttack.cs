using UnityEngine;
using Pattern.Deco;

public class BasicAttack : IAttack
{
    public void Execute()
    {
        Debug.Log("기본 공격 설정");
    }
}
