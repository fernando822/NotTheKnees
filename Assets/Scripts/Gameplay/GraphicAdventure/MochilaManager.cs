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
        if (EventSystem.current.currentSelectedGameObject == llave && llave.activeSelf)
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
    void Start()
    {
        llaveDeGarage = llave.GetComponent<Button>();
        paseDeCarrera = pase.GetComponent<Button>();
        cajaDeHerramientas = herramientas.GetComponent<Button>();
        ActualizarMochila();

    }

    public void ActualizarMochila()
    {
        if (Estados.DevolverEstado("haveKey"))
            ToggleLlaveDeGarage(true);
        else
            ToggleLlaveDeGarage(false);

        if (Estados.DevolverEstado("haveCertificate"))
            TogglePaseDeCarrera(true);
        else
            TogglePaseDeCarrera(false);

        if (Estados.DevolverEstado("haveToolBox"))
            ToggleCajaDeHerramientas(true);
        else
            ToggleCajaDeHerramientas(false);
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
