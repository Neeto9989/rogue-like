using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectCard : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public GameObject object_Drag;
    public GameObject object_Game;
    public Canvas canvas;
    private GameObject objectDragInstance;
    private GameManager gameManager;

    private GameObject[] containers;
    private GameObject container1;
    private GameObject container2;
    private GameObject container3;
    private GameObject container4;

    private void Start()
    {
        gameManager = GameManager.instance;
    }


    
    public void OnDrag(PointerEventData eventData)
    {

        objectDragInstance.transform.position = Input.mousePosition;

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        objectDragInstance = Instantiate(object_Drag, canvas.transform);
        objectDragInstance.transform.position = Input.mousePosition;
        objectDragInstance.GetComponent<ObjectDragging>().card = this;
        Debug.Log("works");

        gameManager.draggingObject = objectDragInstance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        gameManager.PlaceObject();
        gameManager.draggingObject = null;
        Destroy(objectDragInstance);
        
    }
}
