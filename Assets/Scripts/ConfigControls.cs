using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ConfigControls : MonoBehaviour
{
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;
    [SerializeField] InputAction inputAction;



    private void A()
    {
        rebindingOperation = inputAction.PerformInteractiveRebinding()
            .WithControlsExcluding("<Mouse>/position")
            .WithControlsExcluding("<Mouse>/delta")
            .WithControlsExcluding("<Keyboard>/escape")
            .WithControlsExcluding("<Gamepad>/Start")
            .OnMatchWaitForAnother(0.2f)
            .OnComplete(rebindingOperation => b());

        rebindingOperation.Start();
    }

    private void b()
    {
        rebindingOperation.Dispose();
    }

}
