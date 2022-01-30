using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public float timeMovement = 3f;
    private float elapsedTime;
    private float _percentComplete;
    private bool isMoving = true;
    private int _choseMove;
    public GameObject dragImage;
    public GameObject swipeImage;


    private void FixedUpdate()
    {
        if(_choseMove == 0)
        {
            Move(ADMovement.targetPoint);
        }
        if(_choseMove == 1)
        {
            Move(SwipeMovement.swipePoint);
        }
        if (_choseMove == 2)
        {
            Move(DragMovement.dragPosition);
        }
        
    }
   


    private void Move(Vector2 direction)
    {
        elapsedTime = Time.deltaTime;
        _percentComplete = elapsedTime / timeMovement;

        if (isMoving == true)
        {
            transform.position = Vector2.Lerp(transform.position, direction, _percentComplete);
        }

    }

    public void MovementAD()
    {
        _choseMove = 0;
        SaveGame();
    }
    public void MovementSwipe()
    {
        _choseMove = 1;
        SaveGame();
    }
    public void MovementDrag()
    {
        _choseMove = 2;
        SaveGame();
    }

    

    
    private void Start()
    {
        LoadGame();
    }

    void SaveGame()
    {
        PlayerPrefs.SetInt("SavedMoving", _choseMove);
        PlayerPrefs.Save();
        Debug.Log("save");
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedMoving"))
        {
            _choseMove = PlayerPrefs.GetInt("SavedMoving");
            Debug.Log("Game data loaded!");
        }
        else
        {
            PlayerPrefs.DeleteAll();
            _choseMove= -1;
            Debug.Log("Data reset complete");
        }

        if (_choseMove == 1)
        {
            swipeImage.SetActive(true);
        }
        if (_choseMove == 2)
        {
            dragImage.SetActive(true);
        }
    }
}

