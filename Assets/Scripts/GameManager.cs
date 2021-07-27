using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private AdventureGraphicPlayer player;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;
    [SerializeField] PuedeInteractuar puedeInteractuar;



    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<AdventureGraphicPlayer>();
        mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();
        puedeInteractuar = GetComponent<PuedeInteractuar>();
             
    }
    
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        player.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        player.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {

        mostrarTexto.ShowText(player.GetComponent<PuedeInteractuar>().DevolverDescripcion(desc));
    }

    public void PlayerShowKeyObjects()
    {
        
    }

    public void PlayerMenu()
    {
        
    }
    public void ShowDescriptionOfInteractuableObject()
    {
        mostrarTexto.ShowText(obtenerDescripcionObjetoInteractuable());
    }
    public void ShowDescriptionOfObtainedObject()
    {
        mostrarTexto.ShowText(ObtenerDescripcion());
    }
    string obtenerDescripcionObjetoInteractuable()
    {
        return puedeInteractuar.DevolverDescripcion(desc);
    }
    string ObtenerDescripcion()
    {
        return objetoRecogido.MostrarDescripcion();
    }
    

    public void PlayerDemolitionRaceMovement(Vector2 value)
    {

    }

    public void PlayerDemolitionRaceHandBrake()
    {

    }

    public void PlayerDemolitionRaceTurbo()
    {

    }

}
