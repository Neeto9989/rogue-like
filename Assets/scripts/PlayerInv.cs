using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInv : MonoBehaviour
{
    private List<Item> itemList;
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    private void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }
    
    public void AddHealthPotion()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.HealthPotion, amount = 1 });
    }
    public void AddBomb()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.Bomb, amount = 1 });
    }
    public void AddSpeedNecklace()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.SpeedNecklace, amount = 1 });
    }
    public void AddSpeedPotion()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.SpeedPotion, amount = 1 });
    }
    public void AddHealthRing()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.HealthRing, amount = 1 });
    }
    public void AddHeavySword()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.HeavySword, amount = 1 });
    }
    public void AddFastSword()
    {
        inventory.AddItem(new Item { itemType = Item.ItemType.FastSword, amount = 1 });
    }

}
