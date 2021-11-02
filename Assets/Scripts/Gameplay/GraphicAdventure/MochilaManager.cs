using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MochilaManager : MonoBehaviour
{
    [SerializeField] GameObject llave;
    [SerializeField] GameObject pase;
    [SerializeField] GameObject herramientas;
    Button llaveDeGarage;
    Button paseDeCarrera;
    Button cajaDeHerramientas;

    private void OnEnable()
    {
        ActualizarMochila();
        if (llave.activeSelf)
        {
            if (EventSystem.current.currentSelectedGameObject == llave.GetComponent<Selectable>())
            {
                llaveDeGarage.interactable = false;
                llaveDeGarage.interactable = true;
                llaveDeGarage.Select();
            }
            else
            {
                llaveDeGarage.Select();
            }
        }
    }
    void Awake()
    {
        llaveDeGarage = llave.GetComponent<Button>();
        paseDeCarrera = pase.GetComponent<Button>();
        cajaDeHerramientas = herramientas.GetComponent<Button>();
        ActualizarMochila();
    }

    public void ActualizarMochila()
    {
        ToggleLlaveDeGarage(Estados.DevolverEstado("haveKey"));
        TogglePaseDeCarrera(Estados.DevolverEstado("haveCertificate"));
        ToggleCajaDeHerramientas(Estados.DevolverEstado("haveToolBox"));
    }
        
    public void ToggleLlaveDeGarage(bool estado)
    {
        llaveDeGarage.interactable = estado;
    }
    
    public void TogglePaseDeCarrera(bool estado)
    {
        paseDeCarrera.interactable = estado;
    }
   
    public void ToggleCajaDeHerramientas(bool estado)
    {
        cajaDeHerramientas.interactable = estado;
    }
   
}
