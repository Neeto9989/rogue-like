using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIsWon : MonoBehaviour
{

    public StartFights fightManager;
    // Start is called before the first frame update
    void Start()
    {
        fightManager = StartFights.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
        {
            fightManager.GameWon();
        }
    }
}
