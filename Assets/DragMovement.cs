using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class DragMovement : MonoBehaviour, IDragHandler
{
    public float xCoordiate;

    public static Vector2 dragPosition;




    public void OnDrag(PointerEventData eventData)
    {

        transform.position = eventData.position;

        dragPosition = new Vector2(xCoordiate, -1f);

        xCoordiate = ((transform.position.x - (Screen.width / 2)) * 0.01f);
        if (xCoordiate > 6f)
        {
            xCoordiate = 6f;
        }
        if (xCoordiate < -6f)
        {
            xCoordiate = -6f;
        }
    }

    

}

