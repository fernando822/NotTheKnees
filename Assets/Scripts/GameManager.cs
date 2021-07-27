using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    public static bool tieneLlave = false;
    private AdventureGraphicPlayer player;
    /*[SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;*/

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<AdventureGraphicPlayer>();
       /* mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();*/
    }
    
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        player.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        player.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {

        if (test.tag == "NPC" && tieneLlave)
        {
            //mostrarTexto.ShowText("Bien wacho, liberame de este sufrimiento por favor.");
        }
        if (test.name == "Mesa de luz" && !tieneLlave)
        {
            //mostrarTexto.ShowText("Hay una llave dentro de la mesa de luz.");
            tieneLlave = true;
        }

    }

    public void PlayerShowKeyObjects()
    {
        
    }

    public void PlayerMenu()
    {
        
    }

    /*public void ShowDescriptionOfObtainedObject()
    {
        mostrarTexto.ShowText(ObtenerDescripcion());
    }

    string ObtenerDescripcion()
    {
        return objetoRecogido.MostrarDescripcion();
    }*/

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
