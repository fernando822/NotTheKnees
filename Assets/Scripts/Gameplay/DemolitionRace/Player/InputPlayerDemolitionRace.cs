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

        input.PlayerDemolitionRace.ShowControls.performed += OnShowControls;
        input.PlayerDemolitionRace.ShowControls.Enable();


    }

    private void OnShowControls(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerShowControls();
    }

    private void OnHandBrakeEnded(InputAction.CallbackContext obj)
    {
        GameManager.isHandBraking = false;
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

        input.PlayerDemolitionRace.ShowControls.performed -= OnShowControls;
        input.PlayerDemolitionRace.ShowControls.Disable();
    }
}
