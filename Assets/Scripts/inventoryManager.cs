using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryManager : MonoBehaviour
{
    public static inventoryManager instance;
    public List<InventorySlot> inventorySlotsContainer;

    public GameObject inventoryItemPrefabs;

    private InventorySlot inventorySlotSelect;

    private void Awake()
    {
        instance = this;
    }
    public bool AddNewItem(Item item)
    {
        foreach (InventorySlot inventorySlot in inventorySlotsContainer)
        {
            InventoryItem inventoryItem = inventorySlot.GetComponentInChildren<InventoryItem>();

            if (inventoryItem == null)
            {
                SpawnItem(item, inventorySlot);
                return true;
            }
        }

        return false;
    }

    public void SpawnItem(Item item, InventorySlot slot)
    {
        GameObject newItem = Instantiate(inventoryItemPrefabs, slot.transform);
        InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
        inventoryItem.InitItem(item);
    }


    public void RemoveItem()
    {
        if (inventorySlotSelect == null) return;
        InventoryItem inventoryItem = inventorySlotSelect.GetComponentInChildren<InventoryItem>();
        if (inventoryItem != null) Destroy(inventoryItem.gameObject);
        else Debug.Log("No item in Slot !!!!");
    }


    public void UpdateSlotSlect(InventorySlot inventorySlot)
    {
        if (inventorySlotSelect != null)
        {
            inventorySlotSelect.DeSelect();
        }
        inventorySlotSelect = inventorySlot;
        inventorySlotSelect.Select();
        Debug.Log(inventorySlotSelect.gameObject.name);
    }
}
