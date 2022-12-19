using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;
    public bool destroyCard = false;

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
}
