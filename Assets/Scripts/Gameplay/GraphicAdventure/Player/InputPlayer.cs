using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    [SerializeField] GameManagerAventura gameManager;
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
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerAventura>();
       
    }

    private void FixedUpdate()
    {
        gameManager.PlayerMove(movimiento.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movimiento = input.PlayerGraphicAdventure.Movement;
        movimiento.Enable();
        input.PlayerGraphicAdventure.Action.performed += OnAction;
        input.PlayerGraphicAdventure.Action.Enable();

        input.PlayerGraphicAdventure.Backpack.performed += OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Enable();

        input.PlayerGraphicAdventure.ShowKeyObjects.performed += OnShowKeyObjects;
        input.PlayerGraphicAdventure.ShowKeyObjects.Enable();

        input.PlayerGraphicAdventure.Menu.performed += OnMenu;
        input.PlayerGraphicAdventure.Menu.Enable();

    }

    void OnAction(InputAction.CallbackContext obj)
    {
        gameManager.PlayerAction();
    }


    private void OnBackpack(InputAction.CallbackContext obj)
    {
        //gameManager.ShowDescriptionOfObtainedObject();
    }

    void OnShowKeyObjects(InputAction.CallbackContext obj)
    {
        gameManager.PlayerShowKeyObjects();
    }

    void OnMenu(InputAction.CallbackContext obj)
    {
        gameManager.PlayerMenu();
    }

    private void OnDisable()
    {
        movimiento.Disable();
        input.PlayerGraphicAdventure.Action.performed -= OnAction;
        input.PlayerGraphicAdventure.Action.Disable();

        input.PlayerGraphicAdventure.Backpack.performed -= OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Disable();

        input.PlayerGraphicAdventure.ShowKeyObjects.performed -= OnShowKeyObjects;
        input.PlayerGraphicAdventure.ShowKeyObjects.Disable();

        input.PlayerGraphicAdventure.Menu.performed -= OnMenu;
        input.PlayerGraphicAdventure.Menu.Disable();
    }
}
