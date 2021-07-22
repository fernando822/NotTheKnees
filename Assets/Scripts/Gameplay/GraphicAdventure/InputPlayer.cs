using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    void OnMove(InputValue value)
    {
        gameManager.PlayerMove((Vector2)value.Get());
    }

    void OnAction()
    {
        gameManager.PlayerAction();
    }

    void OnBackpack()
    {
        
    }

    void OnShowKeyObjects()
    {
        gameManager.PlayerShowKeyObjects();
    }

    void OnMenu()
    {
        gameManager.PlayerMenu();
    }

}
