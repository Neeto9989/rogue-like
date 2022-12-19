using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyRadar : MonoBehaviour
{
    private GameObject[] multipleEnemys;
    public Transform closestEnemy;
    public GameObject closestEnemy2;
    public bool enemyContact;
    public int damage = 10;
    
    //Scripts
    public PlayerTest playerTest;
    public StartFights fightManager;
    public AudioManager audioManager;

    //Start Fight
    public bool startFightCheck = false;
    public bool fightWonCheck = false;

    public int State;
    public int attackSpeed = 1;
    private static float TimeRemaining = 2f;

    // Start is called before the first frame update
    void Start()
    {
        fightManager = StartFights.instance;
        closestEnemy = null;
        enemyContact = false;
    }

    // Update is called once per frame
    void Update()
    {
        startFightCheck = fightManager.startFight;

        //print(GameObject.FindGameObjectsWithTag("Enemy").Length);

        if (GameObject.FindGameObjectsWithTag("Enemy").Length > 0)
        {
            closestEnemy = getClosestEnemy();
            playerTest = closestEnemy.transform.GetComponent<PlayerTest>();
            audioManager = closestEnemy.transform.GetComponent<AudioManager>();

            if (closestEnemy && startFightCheck == true)
            {
                if (State == 0)
                {
                    if (TimeRemaining > 0f)
                    {
                        TimeRemaining -= Time.deltaTime;
                    }
                    else State = 1;
                }

                if (TimeRemaining < 0)
                {
                    audioManager.DamagedSound();
                    playerTest.TakeDamage(damage);
                    State = 1;
                }
                if (State == 1)
                {
                    TimeRemaining = 2f / attackSpeed;
                    State = 0;
                }
            }

        }
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            fightManager.FightWon();
        }
    }

    public Transform getClosestEnemy()
    {
        multipleEnemys = GameObject.FindGameObjectsWithTag("Enemy");
        float closestDistance = Mathf.Infinity;
        Transform trans = null;

        foreach (GameObject go in multipleEnemys)
        {
            float currentDistance;
            currentDistance = Vector3.Distance(transform.position, go.transform.position);
            if(currentDistance < closestDistance)
            {
                closestDistance = currentDistance;
                trans = go.transform;
            }
        }
        return trans;
    }
 
}
