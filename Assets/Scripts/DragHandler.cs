using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Transform startParent;
    Vector3 startPosition;
    

    public void OnBeginDrag(PointerEventData eventData)
    {

        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        //Debug.Log(DragHandler.itemBeingDragged.tag);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        //If missplaced
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        transform.position = startPosition;
    }
}
