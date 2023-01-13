using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInv : MonoBehaviour
{
    private List<Item> itemList;
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;

    public PlayerTest playerTest;
    public PlayerTest playerTest2;

    public PlayerTest enemyTest;
    public PlayerTest enemyTest2;
    public PlayerTest enemyTest3;
    public PlayerTest enemyTest4;

    public GameObject enemyToDamage;
    public GameObject enemyToDamage2;
    public GameObject enemyToDamage3;
    public GameObject enemyToDamage4;

    public GameObject playerToHeal;
    public GameObject playerToHeal2;
    public int heal = 200;
    public int damage = 50;
    public int maxHP = 200;

    private void Start()
    {
        
        inventory = new Inventory(UseItem);
        uiInventory.SetInventory(inventory);

        playerToHeal = null;
        playerToHeal2 = null;

        enemyToDamage = null;
        enemyToDamage2 = null;
        enemyToDamage3 = null;
        enemyToDamage4 = null;
    }
    private void UseItem(Item item)
    {
        switch (item.itemType)
        {
            case Item.ItemType.HealthPotion:
                ToHeal();
                inventory.RemoveItem(item);
                break;

            case Item.ItemType.Bomb:
                ToDamage();
                inventory.RemoveItem(item);
                break;

            case Item.ItemType.HealthRing:
                ToMaxHP();
                inventory.RemoveItem(item);
                break;
        }
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

    public void ToHeal()
    {
        GameObject[] playersToHeal;
        playersToHeal = GameObject.FindGameObjectsWithTag("Player");
        
        if (playersToHeal.Length == 1)
        {
            playerToHeal = GameObject.FindGameObjectsWithTag("Player")[0];
            playerTest = playerToHeal.transform.GetComponent<PlayerTest>();
            playerTest.HealHealth(heal);
        }
        if (playersToHeal.Length == 2)
        {
            playerToHeal = GameObject.FindGameObjectsWithTag("Player")[0];
            playerToHeal2 = GameObject.FindGameObjectsWithTag("Player")[1];
            playerTest = playerToHeal.transform.GetComponent<PlayerTest>();
            playerTest2 = playerToHeal2.transform.GetComponent<PlayerTest>();
            playerTest.HealHealth(heal);
            playerTest2.HealHealth(heal);
        }
    }
    public void ToMaxHP()
    {
        GameObject[] playersToHeal;
        playersToHeal = GameObject.FindGameObjectsWithTag("Player");

        if (playersToHeal.Length == 1)
        {
            playerToHeal = GameObject.FindGameObjectsWithTag("Player")[0];
            playerTest = playerToHeal.transform.GetComponent<PlayerTest>();
            playerTest.IncreaseMaxHP(maxHP);
        }
        if (playersToHeal.Length == 2)
        {
            playerToHeal = GameObject.FindGameObjectsWithTag("Player")[0];
            playerToHeal2 = GameObject.FindGameObjectsWithTag("Player")[1];
            playerTest = playerToHeal.transform.GetComponent<PlayerTest>();
            playerTest2 = playerToHeal2.transform.GetComponent<PlayerTest>();
            playerTest.IncreaseMaxHP(maxHP);
            playerTest2.IncreaseMaxHP(maxHP);
        }
    }

    public void ToDamage()
    {

        GameObject[] enemiesToDamage;
        enemiesToDamage = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemiesToDamage.Length == 1)
        {
            enemyToDamage = GameObject.FindGameObjectsWithTag("Enemy")[0];
            enemyTest = enemyToDamage.transform.GetComponent<PlayerTest>();
            enemyTest.TakeDamage(damage);
        }
        if (enemiesToDamage.Length == 2)
        {
            enemyToDamage = GameObject.FindGameObjectsWithTag("Enemy")[0];
            enemyToDamage2 = GameObject.FindGameObjectsWithTag("Enemy")[1];
            enemyTest = enemyToDamage.transform.GetComponent<PlayerTest>();
            enemyTest2 = enemyToDamage2.transform.GetComponent<PlayerTest>();
            enemyTest.TakeDamage(damage);
            enemyTest2.TakeDamage(damage);
        }
        if (enemiesToDamage.Length == 3)
        {
            enemyToDamage = GameObject.FindGameObjectsWithTag("Enemy")[0];
            enemyToDamage2 = GameObject.FindGameObjectsWithTag("Enemy")[1];
            enemyToDamage3 = GameObject.FindGameObjectsWithTag("Enemy")[2];
            enemyTest = enemyToDamage.transform.GetComponent<PlayerTest>();
            enemyTest2 = enemyToDamage2.transform.GetComponent<PlayerTest>();
            enemyTest3 = enemyToDamage3.transform.GetComponent<PlayerTest>();
            enemyTest.TakeDamage(damage);
            enemyTest2.TakeDamage(damage);
            enemyTest3.TakeDamage(damage);
        }
        if (enemiesToDamage.Length == 4)
        {
            enemyToDamage = GameObject.FindGameObjectsWithTag("Enemy")[0];
            enemyToDamage2 = GameObject.FindGameObjectsWithTag("Enemy")[1];
            enemyToDamage3 = GameObject.FindGameObjectsWithTag("Enemy")[2];
            enemyToDamage4 = GameObject.FindGameObjectsWithTag("Enemy")[3];
            enemyTest = enemyToDamage.transform.GetComponent<PlayerTest>();
            enemyTest2 = enemyToDamage2.transform.GetComponent<PlayerTest>();
            enemyTest3 = enemyToDamage3.transform.GetComponent<PlayerTest>();
            enemyTest4 = enemyToDamage4.transform.GetComponent<PlayerTest>();
            enemyTest.TakeDamage(damage);
            enemyTest2.TakeDamage(damage);
            enemyTest3.TakeDamage(damage);
            enemyTest4.TakeDamage(damage);
        }

    }
}
