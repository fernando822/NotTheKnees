using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    private PlayerActionControls input;
    private InputAction movimiento;
    private void Awake()
    {
        input = new PlayerActionControls();
        
    }

    void Start()
    {
        input.PlayerGraphicAdventure.Enable();
        input.PlayerDemolitionRace.Disable();
    }

    private void FixedUpdate()
    {
        if (Estados.DevolverEstado("isUiOpen") || Estados.DevolverEstado("dialogueOngoing") || Estados.DevolverEstado("inMenu"))
            movimiento.Disable();
        else
            movimiento.Enable();
        GameManager.GM.PlayerMove(movimiento.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movimiento = input.PlayerGraphicAdventure.Movement;
        movimiento.Enable();

        input.PlayerGraphicAdventure.Action.performed += OnAction;
        input.PlayerGraphicAdventure.Action.Enable();

        input.PlayerGraphicAdventure.Backpack.performed += OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Enable();

        input.PlayerGraphicAdventure.Map.performed += OnMap;
        input.PlayerGraphicAdventure.Map.Enable();

        input.PlayerGraphicAdventure.ShowControls.performed += OnShowControls;
        input.PlayerGraphicAdventure.ShowControls.Enable();

        input.PlayerGraphicAdventure.Menu.performed += OnMenu;
        input.PlayerGraphicAdventure.Menu.Enable();

    }

    void OnAction(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerAction();
    }

    private void OnMap(InputAction.CallbackContext obj)
    {
        GameManager.GM.ToggleMap();
        ToggleMovimiento();

    }

    private void OnBackpack(InputAction.CallbackContext obj)
    {
        GameManager.GM.ToggleBackpack();
        ToggleMovimiento();

    }

    void OnShowControls(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerShowControls();
        ToggleMovimiento();
    }

    void ToggleMovimiento()
    {
        if (Estados.DevolverEstado("isUiOpen"))
        {
            movimiento.Disable();
        }
        else
        {
            movimiento.Enable();
        }
    }
    void OnMenu(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerMenu();
    }

    private void OnDisable()
    {
        movimiento.Disable();
        input.PlayerGraphicAdventure.Action.performed -= OnAction;
        input.PlayerGraphicAdventure.Action.Disable();

        input.PlayerGraphicAdventure.Backpack.performed -= OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Disable();

        input.PlayerGraphicAdventure.Map.performed -= OnMap;
        input.PlayerGraphicAdventure.Map.Disable();

        input.PlayerGraphicAdventure.ShowControls.performed -= OnShowControls;
        input.PlayerGraphicAdventure.ShowControls.Disable();

        input.PlayerGraphicAdventure.Menu.performed -= OnMenu;
        input.PlayerGraphicAdventure.Menu.Disable();
    }
}
