using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochilaManager : MonoBehaviour
{
    [SerializeField] GameObject llaveDeGarage;
    [SerializeField] GameObject paseDeCarrera;
    [SerializeField] GameObject cajaDeHerramienta;
    [SerializeField] GameObject Panel;

    void Start()
    {
        llaveDeGarage.SetActive(false);
        paseDeCarrera.SetActive(false);
        cajaDeHerramienta.SetActive(false);
    }

    public void TogglePanel()
    {
        if (Panel.activeSelf)
            Panel.SetActive(false);
        else
            Panel.SetActive(true);
    }

    public void MostrarLlaveDeGarage()
    {
        llaveDeGarage.SetActive(true);
    }
    public void MostrarPaseDeCarrera()
    {
        llaveDeGarage.SetActive(true);
    }
    public void MostrarCajaDeHerramientas()
    {
        llaveDeGarage.SetActive(true);
    }
}
