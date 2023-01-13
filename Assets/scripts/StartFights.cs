using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFights : MonoBehaviour
{
    public bool startFight = false;
    public bool fightWon = false;
    public bool fightLost = false;
    public GameObject startFightUI;
    public GameObject fightWonUI;
    public GameObject fightLostUI;
    public GameObject gameWonUI;

    public static StartFights instance;

    public void Awake()
    {
        instance = this;
    }

    public void StartFight()
    {
        startFight = true;
        startFightUI.SetActive(false);
    }

    public void FightWon()
    {
        fightWon = true;
        fightWonUI.SetActive(true);
    }

    public void FightLost()
    {
        fightLost = true;
        fightLostUI.SetActive(true);
    }
    public void GameWon()
    {
        fightWon = true;
        SceneManager.LoadScene("Cutscene2");
    }
}
