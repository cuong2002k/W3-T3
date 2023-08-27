using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Menu/Item")]
public class Item : ScriptableObject
{
    [Header("UI")]
    public Sprite icon;
    
    [Header("Stack")]
    public bool stackAble;
}
