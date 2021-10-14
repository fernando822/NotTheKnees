using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MochilaManager : MonoBehaviour
{
    [SerializeField] GameObject llaveDeGarage;
    [SerializeField] GameObject paseDeCarrera;
    [SerializeField] GameObject cajaDeHerramientas;
    private void OnEnable()
    {
        GameObject slotDeLaMochila;
        for (int i = 0; i < 3; i++)
        {
            slotDeLaMochila = transform.GetChild(i).gameObject;
            if (slotDeLaMochila.activeSelf)
            {
                if (EventSystem.current.currentSelectedGameObject != null)
                {
                    if (EventSystem.current.currentSelectedGameObject != slotDeLaMochila)
                    {
                        slotDeLaMochila.GetComponent<Button>().Select();
                        i = 100;
                    }
                    
                }
                else
                {
                    slotDeLaMochila.GetComponent<Button>().Select();
                }
            }
        }
    }
    void Start()
    {
        ActualizarMochila();
    }

    public void ActualizarMochila()
    {
        Debug.Log("La llave " + Estados.DevolverEstado("haveKey"));
        if (Estados.DevolverEstado("haveKey"))
        {
            MostrarLlaveDeGarage();
        }
        else
        {
            llaveDeGarage.SetActive(false);
        }

        if (Estados.DevolverEstado("haveCertificate"))
        {
            MostrarPaseDeCarrera();
        }
        else
        {
            paseDeCarrera.SetActive(false);
        }

        if (Estados.DevolverEstado("haveToolBox"))
        {
            MostrarCajaDeHerramientas();
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
