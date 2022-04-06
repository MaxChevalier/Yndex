using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlots : MonoBehaviour{
    public string itemType;
    public string itemID;
    public Sprite itemSprite;
    void Start ()
    {
    GetComponent<Image>().sprite = itemSprite;
    }
}