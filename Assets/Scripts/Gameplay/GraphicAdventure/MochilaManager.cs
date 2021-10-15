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
        ActualizarMochila();
    }

    public void ActualizarMochila()
    {
        Debug.Log("La llave " + Estados.DevolverEstado("haveKey"));
        if (Estados.DevolverEstado("haveKey"))
        {
            llaveDeGarage.SetActive(true);
        }
        else
        {
            llaveDeGarage.SetActive(false);
        }

        if (Estados.DevolverEstado("haveCertificate"))
        {
            paseDeCarrera.SetActive(true);
        }
        else
        {
            paseDeCarrera.SetActive(false);
        }

        if (Estados.DevolverEstado("haveToolBox"))
        {
            cajaDeHerramientas.SetActive(true);
        }
        else
        {
            cajaDeHerramientas.SetActive(false);
        }
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
