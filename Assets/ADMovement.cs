using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADMovement : MonoBehaviour
{
    
    private Vector2 _leftPoint = new Vector3(-6, -1);
    private Vector2 _rightPoint = new Vector3(6, -1);
    private Vector2 _midletPoint = new Vector3(0, -1);
    public static Vector2 targetPoint;
   

    private void Awake()
    {
        targetPoint = _midletPoint;
    }

    
    public void Update()
    {
        TargetChanger();
    }

    void TargetChanger()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (targetPoint == _rightPoint)
            {
                targetPoint = _midletPoint;
            }
            else if (targetPoint == _midletPoint)
            {
                targetPoint = _leftPoint;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (targetPoint == _leftPoint)
            {
                targetPoint = _midletPoint;
            }
            else if (targetPoint == _midletPoint)
            {
                targetPoint = _rightPoint;
            }
            
        }

    }
}

    
