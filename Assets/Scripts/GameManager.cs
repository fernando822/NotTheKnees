using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private AdventureGraphicPlayer player;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;
    DescObjInteractuable descObjInteractuable;



    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<AdventureGraphicPlayer>();
        mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();
        descObjInteractuable = GetComponent<DescObjInteractuable>();


    }

    public void PlayerMove(Vector2 nuevaPosicion)
    {
        player.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        player.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {

        
    }

    public void PlayerShowKeyObjects()
    {
        
    }

    public void PlayerMenu()
    {
        
    }
    public void ShowDescriptionOfInteractuableObject()
    {
        
    }
    public void ShowDescriptionOfObtainedObject()
    {
        
    }

    string GetDescriptionOfInteractuableObject()
    {
        return descObjInteractuable.MostrarDescripcionInteractuable();
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
