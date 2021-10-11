using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelControles;
    [SerializeField] GameObject mochila;
    [SerializeField] GameObject map;


   
    void Start()
    {
        map.SetActive(false);
        mochila.SetActive(false);
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
    

    void ToggleUI(GameObject ui)
    {
        if (ui.activeSelf)
        {
            ui.SetActive(false);
            Estados.ModificarEstado("isUiOpen",false);
        }
        else
        {
            if (!Estados.DevolverEstado("isUiOpen"))
            {
                ui.SetActive(true);
                Estados.ModificarEstado("isUiOpen", true);
            }
        }
    }
}
