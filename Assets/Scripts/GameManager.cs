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
    public static bool isSomethingSelected = false;
    public static bool dialogueOngoing = false;
    public static int cantidadObjetosObtenidos = 0;
    public static bool haveKey = false;
    public static bool haveCertificate = false;
    public static bool haveToolBox = false;
    public static bool primeraCarreraTerminada = false;
    public static bool primeraVezEnPrimeraEscena = true;


    private Descripciones descripciones;
    public static string nombreDeEscenaActual;
    private AdventureGraphicPlayer scriptPlayerAdventureGraphic;
    [SerializeField] SceneController sceneController;
    [SerializeField] DialogueManager dialogueManager;
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
        nombreDeEscenaActual = SceneManager.GetActiveScene().name;
       
        if (nombreDeEscenaActual == "CarreraDeDemolicion" || nombreDeEscenaActual == "SegundaCarreraDemolicion")
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            uiManager = GameObject.Find("UI").GetComponent<UIManager>();
        }

        if(nombreDeEscenaActual == "AventuraGrafica" || nombreDeEscenaActual == "Taller" || nombreDeEscenaActual == "Torneo")
        {
            sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>(); //Si no se busca asi, no funciona.
            dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>(); //Idem linea anterior.
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>(); //Idem linea anterior.
            playerAdventureGraphic = GameObject.Find("Player");
            descripciones = GetComponent<Descripciones>();
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
        }
        
    }
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        scriptPlayerAdventureGraphic.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        scriptPlayerAdventureGraphic.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        if (isUiOpen)
        {

        }
        else
        {
            if (PuedeInteractuar.interactuable)
            {
                GameObject objetoAInteractuar = DecidirObjetoInteractuable.ObjetoMasCercano(
                scriptPlayerAdventureGraphic.puedeInteractuar.GetGameObjects(), playerAdventureGraphic);

                if(objetoAInteractuar.tag == "NPC")
                {
                    if (!dialogueOngoing)
                    {
                        dialogueManager.IniciarDialogo(objetoAInteractuar.GetComponent<DialogoTrigger>().dialogos);
                    }
                    else
                    {
                        dialogueManager.MostrarSiguienteFrase();
                    }
                    switch (objetoAInteractuar.name)
                    {
                        case "Tio":
                            haveKey = true;
                            break;
                        case "Recepcion":
                            haveCertificate = true;
                            break;
                    }
                    
                }
                else
                {
                    switch (objetoAInteractuar.name)
                    {
                        case "PuertaCasa":
                            if (haveKey)
                            {
                                uiManager.ToggleMap();
                                break;
                            }
                            else
                            {
                                dialogueManager.ShowTextProtagonista("Aunque no me guste, deberia hablar con mi tio primero.");
                                break;
                            }

                        case "PuertaEmpezarCarrera":
                            if (haveCertificate)
                            {
                                if (!primeraCarreraTerminada)
                                {

                                    sceneController.CargarEscena("CarreraDeDemolicion");
                                    break;

                                }
                                else
                                {
                                    sceneController.CargarEscena("SegundaCarreraDemolicion");
                                    break;

                                }
                            }
                            else
                            {
                                dialogueManager.ShowTextProtagonista("Deberia inscribirme en el torneo primero.");
                                break;
                            }
                        case "PuertaEntradaTorneo":
                            uiManager.ToggleMap();
                            break;

                        default:
                            dialogueManager.ShowTextProtagonista(descripciones.GetNombreYDescripcion()[objetoAInteractuar.name]);
                            break;
                    }
                }
               
            }
            else
            {
                dialogueManager.ClearText();
            }
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
        uiManager.ToggleBackpack();
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


    public void PlayerDemolitionRaceHandBrake()
    {
        playerDemolitionRace.handBreak.HandBrake();
        GameManager.isHandBraking = true;
    }

}
