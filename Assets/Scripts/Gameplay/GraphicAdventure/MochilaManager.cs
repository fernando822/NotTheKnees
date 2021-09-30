using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MochilaManager : MonoBehaviour
{
    [SerializeField] GameObject llaveDeGarage;
    [SerializeField] GameObject paseDeCarrera;
    [SerializeField] GameObject cajaDeHerramientas;

    void Start()
    {
        llaveDeGarage.SetActive(false);
        paseDeCarrera.SetActive(false);
        cajaDeHerramientas.SetActive(false);
    }


    public void MostrarLlaveDeGarage()
    {
        llaveDeGarage.SetActive(true);
    }
    public void MostrarPaseDeCarrera()
    {
        paseDeCarrera.SetActive(true);
    }
    public void MostrarCajaDeHerramientas()
    {
        cajaDeHerramientas.SetActive(true);
    }
}
