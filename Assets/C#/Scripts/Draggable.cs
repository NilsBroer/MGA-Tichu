using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform previousFormOfParent = null;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Card picked up.");
        var parent = this.transform.parent;
        previousFormOfParent = parent;
        this.transform.SetParent(parent.parent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;    
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(previousFormOfParent);
        Debug.Log("Card dropped down.");
    }
}
