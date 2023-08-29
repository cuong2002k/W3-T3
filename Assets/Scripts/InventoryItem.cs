using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class InventoryItem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public Image image;
    public Item item;
    public int count = 1;
    
    [HideInInspector] public Transform parentAfterDrag;

    // private void Start()
    // {
    //     InitItem(item);
    // }

    public void InitItem(Item newItem)
    {
        item = newItem;
        image.sprite = newItem.icon;
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        this.transform.SetParent(transform.root);
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        image.raycastTarget = true;
        transform.SetParent(parentAfterDrag);
    }
}

