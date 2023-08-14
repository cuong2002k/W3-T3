using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemContainer : MonoBehaviour
{
    public List<Item> listItem;
    public Transform parrentItem;
    private void Start()
    {
        for (int i = 0; i < parrentItem.childCount; i++)
        {
            if (i < listItem.Count)
            {
                GameObject item = parrentItem.GetChild(i).gameObject;
                item.transform.GetChild(0).GetComponent<Image>().sprite = listItem[i].icon;
                item.transform.GetChild(1).GetComponent<Text>().text = listItem[i].amount.ToString();
            }
        }
    }

}
