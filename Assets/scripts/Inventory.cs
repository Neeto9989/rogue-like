using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public event EventHandler OnItemListChanged;
    private List<Item> itemList;
    private Inventory inventory;
    public bool invFull = false;
    private Action<Item> useItemAction;

    public Inventory(Action<Item> useItemAction)
    {
        this.useItemAction = useItemAction;
        itemList = new List<Item>();
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        if (invFull == false)
        {
            itemList.Add(item);
            OnItemListChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    public void UseItem(Item item)
    {
        useItemAction(item);
    }

    public void RemoveItem(Item item)
    {
        itemList.Remove(item);
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }

 

}
