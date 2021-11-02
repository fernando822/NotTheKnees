using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class ConfigControls : MonoBehaviour
{
    private InputActionRebindingExtensions.RebindingOperation rebindingOperation;

    [SerializeField] InputAction inputAction;
    [SerializeField] InputActionReference inputActionReference;
    [SerializeField] private GameObject button;
    

    private string actionName;
    private int selectedBinding;
    [SerializeField] int bindingIndex;
    private InputBinding inputBinding;

<<<<<<< HEAD
=======
    private void Start()
    {
       
    }
>>>>>>> RamaDePruebas
    private void Rebinding()
    {

        Debug.Log("fgszdfgdf");
        button.SetActive(false);

        rebindingOperation = inputActionReference.action.PerformInteractiveRebinding(bindingIndex)
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
        button.SetActive(true);

        
    }

}
