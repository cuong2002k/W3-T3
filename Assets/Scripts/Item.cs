using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Menu/Item")]
public class Item : ScriptableObject
{
    public string nameItem;
    public Sprite icon;
    public int amount;
}
