using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerAventura : MonoBehaviour{

    public static bool tieneLlave = false;
    public static bool interactuoConNPC = false;

    private GameObject player;
    private Descripciones descripciones;
    private AdventureGraphicPlayer adventureGraphicPlayer;
    private PuedeInteractuar puedeInteractuar;
    [SerializeField] SceneController cambioDeNivel;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;
    [SerializeField] UIManager uiManager;

    private void Start()
    {
        cambioDeNivel = GameObject.Find("SceneManager").GetComponent<SceneController>(); //Si no se busca asi, no funciona.
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>(); //Idem linea anterior.
        player = GameObject.Find("Player");
        descripciones = GetComponent<Descripciones>();
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

            switch (objetoAInteractuar.name)
            {
                case "NPC":
                    mostrarTexto.ShowText(DialogoNPC.DialogoDelNPC(tieneLlave));
                    interactuoConNPC = true;
                    mostrarTexto.DefinirTextoDelEmisor("Pedro el NPC perdido");
                    break;

                case "Mesa de luz":                    
                    mostrarTexto.ShowText(DescripcionMesaDeLuz.DescripcionDeLaMesaDeLuz(tieneLlave));
                    if (!tieneLlave && interactuoConNPC)
                    {
                        tieneLlave = true;
                        uiManager.MostrarLlave();
                    }
                    break;

                case "Puerta":
                    if (tieneLlave)
                    {
                        cambioDeNivel.CargarEscena("CarreraDeDemolicion");
                    }
                    else
                    {
                        mostrarTexto.ShowText(DescripcionPuerta.DescripcionDeLaPuerta(tieneLlave));
                    }
                    break;

                default:
                    mostrarTexto.ShowText(descripciones.GetNombreYDescripcion()[objetoAInteractuar.name]);
                    break;
            }


        }
        else
        {
            mostrarTexto.ClearText();
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
