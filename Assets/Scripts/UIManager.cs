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
            GameManager.isUiOpen = false;
            ui.SetActive(false);
        }
        else
        {
            if (!GameManager.isUiOpen)
            {
                GameManager.isUiOpen = true;
                ui.SetActive(true);
            }
        }
    }
}
