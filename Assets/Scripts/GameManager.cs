using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private UIManager UIManager;
    private AdventureGraphicPlayer adventureGraphicPlayer;
    private GameObject player;
    private PuedeInteractuar puedeInteractuar;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;

    private void Start()
    {
        UIManager = GetComponent<UIManager>();
        player = GameObject.Find("Player");
        puedeInteractuar = player.GetComponent<PuedeInteractuar>();
        adventureGraphicPlayer = player.GetComponent<AdventureGraphicPlayer>();
        mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();
    }

    public void PlayerMove(Vector2 nuevaPosicion)
    {
        adventureGraphicPlayer.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        adventureGraphicPlayer.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        
        if (PuedeInteractuar.interactuable)
        {
            GameObject objetoAInteractuar = DecidirObjetoInteractuable.ObjetoMasCercano(
                puedeInteractuar.GetGameObjects(), player);
            //mostrarTexto.ShowText(objetoAInteractuar);
            
            if (objetoAInteractuar.name == "NPC")
            {
                DialogoNPC.DialogoDelNPC(tieneLlave);
            }
            if (objetoAInteractuar.name == "Mesa de luz")
            {
                UIManager.MostrarLlave();
            }

        }

       
    }

    public void PlayerShowKeyObjects()
    {
     /* uiManager.MostrarLlave(); */
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
