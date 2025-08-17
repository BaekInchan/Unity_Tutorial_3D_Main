using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Crop crop; // 슬롯에 들어올 아이템
    [SerializeField] private Image slotImage;
    [SerializeField] private Button slotButton;

    public bool isEmpty = true;


    private void Awake()
    {
        slotButton.onClick.AddListener(UseCrop);
    }

    private void OnEnable()
    {
        slotImage.gameObject.SetActive(!isEmpty);
        slotButton.interactable = !isEmpty;
       
    }

    public void AddCrop(Crop crop)
    {
        isEmpty = false;

        this.crop = crop;
        slotImage.sprite = crop.icon;

    }

    private void UseCrop()
    {
        Debug.Log("Use 1");
        if (crop != null)
        {

            Debug.Log("Use 2");
            crop.Use();
            isEmpty = true;
            slotButton.interactable = false;
            slotImage.gameObject.SetActive(false);
            GameManager.Instance.item.UseItem();
            crop.useAction?.Invoke();
        }
    }
}