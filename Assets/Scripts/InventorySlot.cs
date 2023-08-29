using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour, IDropHandler, IPointerClickHandler, IPointerExitHandler
{
    public Image image;
    public Color selectColor, notSelectColor;

    private void Start()
    {
        DeSelect();
    }
    public void Select()
    {
        image.color = selectColor;
    }

    public void DeSelect()
    {
        image.color = notSelectColor;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();
            inventoryItem.parentAfterDrag = transform;
        }
        else
        {

            InventoryItem inventoryToSlot = this.GetComponentInChildren<InventoryItem>();
            InventoryItem inventoryItem = eventData.pointerDrag.GetComponent<InventoryItem>();

            inventoryToSlot.transform.SetParent(inventoryItem.parentAfterDrag);
            inventoryItem.parentAfterDrag = transform;


        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        InventorySlot inventorySlot = eventData.pointerClick.GetComponent<InventorySlot>();
        inventoryManager.instance.UpdateSlotSlect(inventorySlot);

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }
}
