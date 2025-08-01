using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public partial class StudyPartial : MonoBehaviour
{
    public void MethodB()
    {
        Debug.Log("MethodB");
    }
}

public class StudyParameter : MonoBehaviour
{
    public int number1 = 1;
    public int number2;

    public GameObject player;
    public GameObject enemy;
    public GameObject item;

    public List<GameObject> objs = new List<GameObject>();

    private void Start()
    {
        StudyPartial study = new StudyPartial();
        study.MethodB();

        objs.Add(player);
        objs.Add(enemy);
        objs.Add(item);

        GameObjectActivate2(false, player, item);
        int[] intArray = new int[3] { 10, 20, 30 };
        List<int> intList = new List<int>() { 10, 20, 30 };
        intList.Add(40);
        intList.Add(50);
        ArrayParameter(intList);

        ParamsParameter(10, 20, 30, 40, 50);

        NomalParameter(number1);
        Debug.Log($"Call by Value :{number1}");

        ReferenceParameter(ref number1);
        Debug.Log($"Call by Reference : {number1}");

        DefaultParameter(5);
    }

    private void GameObjectActivate()
    {
        //player.SetActive(false);
        //enemy.SetActive(false);
        //item.SetActive(false);
        foreach( var o in objs)
        {
            o.SetActive(false);
        }
    }

    private void GameObjectActivate2(bool isActive, params GameObject[] objs)
    {
        foreach (var o in objs) 
            o.SetActive(isActive);
    }


    // 일반적인 매개변수 방법 -> Call by Value
    private void NomalParameter(int num)
    {
        num = 10;
    }


    // 참조 방식의 매개변수 -> Call by Reference
    private void ReferenceParameter(ref int num)
    {
        num = 10;
    }


    private void OutParameter(out int num, out int num2)
    {
        num = 30;
        num2 = 50;
    }

    private int ChangeNumber(out int num)
    {
        num = 10;

        int result = 100;
        return result;
    }

    // 선택적 매게변수 (디폴트 매개변수)
    private void DefaultParameter(int num = 3)
    {
        number1 = num;
    }
    private void ArrayParameter(List<int> numbers)
    {
        foreach(var n in numbers)
        {
            Debug.Log(n);
        }
    }

    private void ParamsParameter(params int[] numbers)
    {
        foreach (var n in numbers)
        {
            Debug.Log(n);
        }
    }
    
    // 오버로딩 : 매개변수를 다르게해서 다른 기능을 구현하는 방법
    private void OverloadingMethod() { Debug.Log("기능 A"); }
    private void OverloadingMethod(int num) { Debug.Log("기능 B"); }
    private void OverloadingMethod(float num) { Debug.Log("기능 C"); }
    private void OverloadingMethod(bool isnum) { Debug.Log("기능 D"); }
    private void OverloadingMethod(int num1, int num2) { Debug.Log("기능 E"); }
  
}
