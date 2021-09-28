using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject llave;
    [SerializeField] GameObject panelControles;
    [SerializeField] GameObject mochila;
    [SerializeField] GameObject map;

    public void TogglePanel()
    {
        if (panelControles.activeSelf)
            panelControles.SetActive(false);
        else
            panelControles.SetActive(true);
    }

    public void ToggleBackpack()
    {
        if (mochila.activeSelf)
            mochila.SetActive(false);
        else
            mochila.SetActive(true);
    }
    public void ToggleMap()
    {
        if (map.activeSelf)
            map.SetActive(false);
        else
            map.SetActive(true);
    }
    void Start()
    {
        llave.SetActive(false);
    }

    public void MostrarLlave()
    {
        llave.SetActive(true);   
    }

    public void OcultarLlave()
    {
        llave.SetActive(false);
    }
}
