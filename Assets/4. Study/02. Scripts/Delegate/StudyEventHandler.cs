using System;
using System.Runtime.CompilerServices;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class StudyEventHandler : MonoBehaviour
{

    public class CharacterData : EventArgs
    {
        public string name;
        public int level;
        public float hp;
        public float mp;
        public float damage;

        public CharacterData(string name, int level, float hp, float mp, float damage)
        {
            this.name = name;
            this.level = level;
            this.hp = hp;
            this.mp = mp;
            this.damage = damage;

        }

    }

    private event EventHandler handler;

    void Start()
    {
        handler += CreateCharacter;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CharacterData data = new CharacterData("A", 1, 2, 3, 4);
            handler?.Invoke(this, EventArgs.Empty);
        }
    }

    private void MethodA(object o, EventArgs e)
    {
        Debug.Log("MethodA");
    }

    private void CreateCharacter(object o, EventArgs e)
    {
        var data = (CharacterData)e;
        Debug.Log($"{data.name} / {data.level} 데이터를 가진 캐릭터 생성");
    }




}
