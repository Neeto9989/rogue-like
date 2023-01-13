using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public PlayerTest playerTest;
    public PlayerTest playerTest2;
    public GameObject playerToHeal;
    public GameObject playerToHeal2;
    public int heal = 200;

    void Start()
    {
        playerToHeal = null;
        playerToHeal2 = null;
    }

    void Update()
    {

    }
    public void ToHeal()
    {
        playerToHeal = GameObject.FindGameObjectsWithTag("Player")[0];
        playerToHeal2 = GameObject.FindGameObjectsWithTag("Player")[1];
        playerTest = playerToHeal.transform.GetComponent<PlayerTest>();
        playerTest2 = playerToHeal2.transform.GetComponent<PlayerTest>();
        playerTest.HealHealth(heal);
        playerTest2.HealHealth(heal);
    }
}
