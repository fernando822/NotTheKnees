using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputPlayerDemolitionRace : MonoBehaviour
{
    [SerializeField] GameManagerRace gameManager;
    private PlayerActionControls input;
    private InputAction movimiento;

    private void Awake()
    {
        input = new PlayerActionControls();
    }
    void Start()
    {
        input.PlayerGraphicAdventure.Disable();
        input.PlayerDemolitionRace.Enable();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerRace>();
    }

    private void FixedUpdate()
    {
        gameManager.PlayerDemolitionRaceMovement(movimiento.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movimiento = input.PlayerDemolitionRace.Movement;
        movimiento.Enable();
        input.PlayerDemolitionRace.HandBrake.performed += OnHandBrake;
        input.PlayerDemolitionRace.HandBrake.Enable();

        input.PlayerDemolitionRace.Turbo.performed += OnTurbo;
        input.PlayerDemolitionRace.Turbo.Enable();
    }

    void OnHandBrake(InputAction.CallbackContext obj)
    {
        gameManager.PlayerDemolitionRaceHandBrake();
    }
    void OnTurbo(InputAction.CallbackContext obj)
    {
        gameManager.PlayerDemolitionRaceTurbo();
    }

    private void OnDisable()
    {
        movimiento.Disable();
        input.PlayerDemolitionRace.HandBrake.performed -= OnHandBrake;
        input.PlayerDemolitionRace.HandBrake.Disable();

        input.PlayerDemolitionRace.Turbo.performed -= OnTurbo;
        input.PlayerDemolitionRace.Turbo.Disable();
    }
}
