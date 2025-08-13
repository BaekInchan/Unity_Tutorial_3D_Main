using UnityEngine;
using System;

public class Crop : MonoBehaviour
{
    [SerializeField] private string cropName; 

    public Sprite icon;
    public Action useAction;

    private void Start()
    {
        useAction += Use;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Get();
        }
    }

    public void Get()
    {
        // 인벤토리에 작물 추가
        if (GameManager.Instance.item.CheckItemCount())
        {
            GameManager.Instance.item.GetItem(this);
            Debug.Log($"{cropName} 획득");
            gameObject.SetActive(false);

        }

        else
        {
            Debug.Log("인벤토리에 공간이 부족합니다");
        }

    }

    public void Use()
    {
        Debug.Log($"{cropName}을 사용했습니다");
    }
}
