using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerAventura : MonoBehaviour{

    public static bool tieneLlave = false;
    private UIManager UIManager;
    private AdventureGraphicPlayer adventureGraphicPlayer;
    private GameObject player;
    private PuedeInteractuar puedeInteractuar;
    private SceneController cambioDeNivel;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;

    private void Start()
    {
        cambioDeNivel = GetComponent<SceneController>();
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
            mostrarTexto.ShowText(objetoAInteractuar.name);

            if (objetoAInteractuar.name == "NPC")
            {
                mostrarTexto.ShowText(DialogoNPC.DialogoDelNPC(tieneLlave));
            }
    
            if (objetoAInteractuar.name == "Mesa de luz" && !tieneLlave)
            {
                mostrarTexto.ShowText("Hay una llave dentro de la mesa de luz.");
                UIManager.MostrarLlave();
                tieneLlave = true;
            }

            if (objetoAInteractuar.name == "Puerta" && tieneLlave)
            {
                cambioDeNivel.CargarEscena("CarreraDeDemolicion");
            }
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

}
