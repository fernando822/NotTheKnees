using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    private DemolitionRacePlayer playerDemolitionRace;
    private GameObject playerAdventureGraphic;

    public static bool isHandBraking = false;
    public static bool isUiOpen = false;


    private Descripciones descripciones;
    private AdventureGraphicPlayer scriptPlayerAdventureGraphic;
    [SerializeField] SceneController cambioDeNivel;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] UIManager uiManager;

    public static GameManager GetGameManager
    {
        get
        {
            if (GM == null)
            {
                Debug.Log("GameManager is null");
            }
            return GM;
        }
    }
    
    private void Awake()
    {
        GM = this;
    }
    private void Start()
    {
        string nombreDeEscena = SceneManager.GetActiveScene().name;
       
        if (nombreDeEscena == "CarreraDeDemolicion")
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            uiManager = GameObject.Find("UI").GetComponent<UIManager>();
        }

        if(nombreDeEscena == "AventuraGrafica" || nombreDeEscena == "Taller" || nombreDeEscena == "Torneo")
        {
            cambioDeNivel = GameObject.Find("SceneManager").GetComponent<SceneController>(); //Si no se busca asi, no funciona.
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>(); //Idem linea anterior.
            playerAdventureGraphic = GameObject.Find("Player");
            descripciones = GetComponent<Descripciones>();
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
            mostrarTexto = GetComponent<MostrarTexto>();
        }
        
    }
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        scriptPlayerAdventureGraphic.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        scriptPlayerAdventureGraphic.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        if (PuedeInteractuar.interactuable)
        {
            GameObject objetoAInteractuar = DecidirObjetoInteractuable.ObjetoMasCercano(
            scriptPlayerAdventureGraphic.puedeInteractuar.GetGameObjects(), playerAdventureGraphic);

            switch (objetoAInteractuar.name)
            {
                case "Puerta":
                        cambioDeNivel.CargarEscena("CarreraDeDemolicion");
                    break;

                default:
                    mostrarTexto.ShowTextProtagonista(descripciones.GetNombreYDescripcion()[objetoAInteractuar.name]);
                    break;
            }
        }
        else
        {
            mostrarTexto.ClearText();
        }

    }

    public void PlayerShowControls()
    {
        uiManager.TogglePanel();
    }

    public void PlayerMenu()
    {

    }

    public void ToggleBackpack()
    { 
        uiManager.TogglePanel();
    }
    public void ToggleMap()
    {
        uiManager.ToggleMap();
    }



    

    public void PlayerDemolitionRaceMovement(Vector2 value)
    {
        playerDemolitionRace.movementScript.Accelerate(value.y);
        playerDemolitionRace.movementScript.SetRotation(value.x);
    }
    public void PlayerDemolitionRaceVerticalMovement(float value)
    {
        playerDemolitionRace.movementScript.Accelerate(value);
    }

    public void PlayerDemolitionRaceHandBrake()
    {
        playerDemolitionRace.handBreak.HandBrake();
        GameManager.isHandBraking = true;
    }

}
