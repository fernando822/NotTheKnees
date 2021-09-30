using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelControles;
    [SerializeField] GameObject mochila;
    [SerializeField] GameObject map;

    public void TogglePanel()
    {
        if (panelControles.activeSelf)
        { 
            GameManager.isUiOpen = false;
            panelControles.SetActive(false);
        }
        else
        {
            GameManager.isUiOpen = true;
            panelControles.SetActive(true);
        }
            
    }

    public void ToggleBackpack()
    {
        if (mochila.activeSelf) 
        {
            GameManager.isUiOpen = false;
            mochila.SetActive(false);
        }
        else
        {
            GameManager.isUiOpen = true;
            mochila.SetActive(true);
        }
    }
    public void ToggleMap()
    {
        if (map.activeSelf)
        { 
            GameManager.isUiOpen = false;
            map.SetActive(false);
        }
        else
        {
            GameManager.isUiOpen = true;
            map.SetActive(true);
        }
            
    }
    void Start()
    {
    }

}
