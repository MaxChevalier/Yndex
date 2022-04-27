using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class InventorySlot
{
    [SerializeField] private InventoryItemData itemData;
    [SerializeField] private int stackSize;

    public InventoryItemData ItemData => itemData;

    public int StackSize => stackSize;

    public InventorySlot(InventoryItemData source, int amount)
    {
        itemData = source;
        stackSize = amount;
    }
    public InventorySlot()
    {
        ClearSlot();
    }

    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }
    public bool RoomLeftInSTack(int amountToAdd, out int amountRemaining)
    {
        amountRemaining = ItemData.MaxStackSize - stackSize;

        return RoomLeftInSTack(amountToAdd);
    }
    public bool RoomLeftInSTack(int amountToAdd)
    {
        if (stackSize + amountToAdd <= itemData.MaxStackSize) return true;
        else return false ;
    }
    public void RemoveFromStack(int amount)
    {
        stackSize -= amount;
    }

    public void AddToStack (int amount)
    {
        stackSize += amount;
    }
}
