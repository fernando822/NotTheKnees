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
        gameManager.PlayerDemolitionRace_Movement((Vector2)value.Get());
    }
    void OnHandBrake()
    {
        gameManager.PlayerDemolitionRace_HandBrake();
    }
    void OnTurbo()
    {
        gameManager.PlayerDemolitionRace_Turbo();
    }
    void Update()
    {
        
    }
}
