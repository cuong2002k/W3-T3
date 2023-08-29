using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public List<Item> ItemContainer;
    public inventoryManager inventoryManager;

    public void Spawn()
    {
        int ran = Random.Range(0, ItemContainer.Count);
        bool check = inventoryManager.AddNewItem(ItemContainer[ran]);
        if (check) Debug.Log("New Item");
        else Debug.Log("Full Inventory!!!");
    }



}
