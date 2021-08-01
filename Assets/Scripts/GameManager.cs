using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private AdventureGraphicPlayer player;
    private SceneController cambioDeNivel;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;
    

    private void Start()
    {
        cambioDeNivel = GetComponent<SceneController>();
        player = GameObject.Find("Player").GetComponent<AdventureGraphicPlayer>();
        mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();
       
    }
    
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        player.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        player.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        if(objetoAInteractuar.name == "Puerta")
        {
            cambioDeNivel.CargarEscena("CarreraDeDemolicion");
        }
    }

    public void PlayerShowKeyObjects()
    {
        
    }

    public void PlayerMenu()
    {
        
    }

    public void ShowDescriptionOfObtainedObject()
    {
        mostrarTexto.ShowText(ObtenerDescripcion());
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
