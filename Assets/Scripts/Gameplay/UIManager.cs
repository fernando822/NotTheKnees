using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject llave;
    [SerializeField] GameObject panelControles;

    public void TogglePanel()
    {
        if (panelControles.activeSelf)
            panelControles.SetActive(false);
        else
            panelControles.SetActive(true);
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
