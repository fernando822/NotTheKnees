using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelControles;
    [SerializeField] GameObject mochila;
    [SerializeField] GameObject map;
    [SerializeField] GameObject turboEffect;


    
    void Start()
    {
        if(!GameManager.nombreDeEscenaActual.Contains("Carrera") && !GameManager.nombreDeEscenaActual.Contains("Menu"))
        {
            map.SetActive(false);
            mochila.SetActive(false);
        }
    }
    private void Update()
    {
        ActualizarEfectoTurbo();


    }
    public void TogglePanel()
    {
        ToggleUI(panelControles);
    }

    public void ToggleBackpack()
    {
        ToggleUI(mochila);
    }
    public void ToggleMap()
    {
        ToggleUI(map);
    }
    
    void ActualizarEfectoTurbo()
    {
        if (GameManager.nombreDeEscenaActual.Contains("Carrera"))
        {
            if (Turbo.turboRestante > 0)
            {
                if (!turboEffect.activeSelf)
                    turboEffect.SetActive(true);
            }
            else
            {
                if (turboEffect.activeSelf)
                    turboEffect.SetActive(false);
            }
        }
    }

    void ToggleUI(GameObject ui)
    {
        if (!Estados.DevolverEstado("dialogueOngoing"))
        {
            if (ui.activeSelf)
            {
                ui.SetActive(false);
                Estados.ModificarEstado("isUiOpen", false);
            }
            else
            {
                if (!Estados.DevolverEstado("isUiOpen"))
                {
                    Estados.ModificarEstado("isUiOpen", true);
                    ui.SetActive(true);
                    Debug.Log(Estados.DevolverEstado("isUiOpen"));
                }
            }
        }
    }
}
