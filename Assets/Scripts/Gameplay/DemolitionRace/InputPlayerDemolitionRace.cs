using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputPlayerDemolitionRace : MonoBehaviour
{
    private PlayerActionControls input;
    private InputAction movimiento;
    private InputAction acceleracion;

    private void Awake()
    {
        input = new PlayerActionControls();
    }
    void Start()
    {
        input.PlayerGraphicAdventure.Disable();
        input.PlayerDemolitionRace.Enable();
    }

    private void FixedUpdate()
    {
        GameManager.GM.PlayerDemolitionRaceVerticalMovement(acceleracion.ReadValue<float>());
        GameManager.GM.PlayerDemolitionRaceMovement(movimiento.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movimiento = input.PlayerDemolitionRace.Movement;
        movimiento.Enable();

        acceleracion = input.PlayerDemolitionRace.Accelerate;
        acceleracion.Enable();

        input.PlayerDemolitionRace.HandBrake.started += OnHandBrake;
        input.PlayerDemolitionRace.HandBrake.canceled += OnHandBrakeEnded;
        input.PlayerDemolitionRace.HandBrake.Enable();


    }

    private void OnHandBrakeEnded(InputAction.CallbackContext obj)
    {
        GameManager.isHandBraking = false;
        Debug.Log("Finished" + GameManager.isHandBraking);
    }

    void OnHandBrake(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerDemolitionRaceHandBrake();
    }
   

    private void OnDisable()
    {
        movimiento.Disable();
        acceleracion.Disable();

        input.PlayerDemolitionRace.HandBrake.started -= OnHandBrake;
        input.PlayerDemolitionRace.HandBrake.performed -= OnHandBrake;
        input.PlayerDemolitionRace.HandBrake.Disable();

    }
}
