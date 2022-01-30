using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class SwipeMovement : MonoBehaviour, IDragHandler, IBeginDragHandler,IEndDragHandler
{
    public float xCoordiate;

    private  float _beginSwipePosition;
    private  float _endSwipePosition;
    public static float swipeSide;

    private Vector2 _leftPoint = new Vector3(-6, -1);
    private Vector2 _rightPoint = new Vector3(6, -1);
    private Vector2 _midletPoint = new Vector3(0, -1);
    public static Vector2 swipePoint;

    private void Start()
    {
        swipePoint = _midletPoint;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       
        _beginSwipePosition = transform.position.x ;
        
    }

    public void OnDrag(PointerEventData eventData)
    {

        transform.position = eventData.position;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _endSwipePosition = transform.position.x;

        swipeSide = _beginSwipePosition - _endSwipePosition;
        if( swipeSide > 0)
        {
            if (swipePoint == _rightPoint)
            {
                swipePoint = _midletPoint;
            }
            else if (swipePoint == _midletPoint)
            {
                swipePoint = _leftPoint;
            }
            
        }

        if (swipeSide < 0)
        {
            if (swipePoint == _leftPoint)
            {
                swipePoint = _midletPoint;
            }
            else if (swipePoint == _midletPoint)
            {
                swipePoint = _rightPoint;
            }
           
        }
        
    }
}
