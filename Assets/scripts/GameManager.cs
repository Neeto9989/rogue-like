using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;
    public bool destroyCard = false;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject cutScene5;
    public GameObject cutScene6;
    public GameObject cutScene7;
    public GameObject cutScene8;
    public GameObject cutScene9;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
    public void PlaceObject()
    {
        if (draggingObject != null && currentContainer != null)
        {
            Instantiate(draggingObject.GetComponent<ObjectDragging>().card.object_Game, currentContainer.transform);
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
            Destroy(draggingObject.GetComponent<ObjectDragging>().card);
            destroyCard = true;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Level2()
    {
        level2.SetActive(true);
        level1.SetActive(false);
        cutScene5.SetActive(true);

    }
    public void Level3()
    {
        level3.SetActive(true);
        level2.SetActive(false);

    }
    public void Level4()
    {
        level4.SetActive(true);
        level3.SetActive(false);
        cutScene6.SetActive(true);

    }
    public void CutScene5()
    {
        cutScene5.SetActive(false);
    }
    public void CutScene6()
    {
        cutScene6.SetActive(false);
    }
    public void CutScene7()
    {
        cutScene8.SetActive(true);
        cutScene7.SetActive(false);
    }
    public void CutScene8()
    {
        cutScene8.SetActive(true);
        cutScene7.SetActive(false);
    }
    public void CutScene9()
    {
        cutScene9.SetActive(true);
        cutScene8.SetActive(false);
    }

    public void EndCredits()
    {
        SceneManager.LoadScene("EndCredits");
    }
}
