using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{

    public int maxHealth = 200;
    public int currentHealth;
    public GameObject death;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            death.SetActive(false);

        }
    }
    public void HealHealth(int heal)
    {
        currentHealth += heal;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        healthBar.SetHealth(currentHealth);
        
    }
    public void IncreaseMaxHP(int maxHP)
    {
        maxHealth = maxHealth + maxHP;
        currentHealth = currentHealth + maxHP;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }
}
