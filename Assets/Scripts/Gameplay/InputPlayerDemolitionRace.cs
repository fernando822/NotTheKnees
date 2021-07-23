using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputPlayerDemolitionRace : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    void OnMove(InputValue value)
    {
        gameManager.PlayerDemolitionRaceMovement((Vector2)value.Get());
    }
    void OnHandBrake()
    {
        gameManager.PlayerDemolitionRaceHandBrake();
    }
    void OnTurbo()
    {
        gameManager.PlayerDemolitionRaceTurbo();
    }
    void Update()
    {
        
    }
}
