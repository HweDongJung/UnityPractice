using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTest : MonoBehaviour, IBeginDragHandler, IDragHandler,IEndDragHandler
{
    public void OnBeginDrag(PointerEventData data)
    {
        transform.position = data.position;    
    }

    public void OnDrag(PointerEventData data)
    {
        transform.position = data.position;

    }

    public void OnEndDrag(PointerEventData data)
    {
        transform.position = data.position;

    }
}
