using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    private DemolitionRacePlayer playerDemolitionRace;
    private GameObject playerAdventureGraphic;

    


    private Descripciones descripciones;
    public static string nombreDeEscenaActual;
    private AdventureGraphicPlayer scriptPlayerAdventureGraphic;
    [SerializeField] SceneController sceneController;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] UIManager uiManager;
    [SerializeField] MochilaManager mochilaManager;
    

    
    
    private void Awake()
    {
        if (GM != null)
            GameObject.Destroy(GM);
        else
            GM = this;
        DontDestroyOnLoad(this);
        ActualizarReferencias();
    }
    private void Start()
    {
        Estados.estados = new Dictionary<string, bool>();
        Estados.AgregarEstado("isHandBraking", false);
        Estados.AgregarEstado("isUiOpen", false);
        Estados.AgregarEstado("isSomethingSelected", false);
        Estados.AgregarEstado("dialogueOngoing", false);
        Estados.AgregarEstado("haveKey", false);
        Estados.AgregarEstado("haveCertificate", false);
        Estados.AgregarEstado("haveToolBox", false);
        Estados.AgregarEstado("primeraCarreraTerminada", false);
        Estados.AgregarEstado("primeraVezEnPrimeraEscena", true);
    }
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        if (!Estados.DevolverEstado("dialogueOngoing"))
        {
            scriptPlayerAdventureGraphic.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
            scriptPlayerAdventureGraphic.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
        }
    }

    public void PlayerAction()
    {
        
        if (Estados.DevolverEstado("isUiOpen"))
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
                    if (!Estados.DevolverEstado("dialogueOngoing"))
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
                            Estados.ModificarEstado("haveKey",true);
                            mochilaManager.ActualizarMochila();
                            break;
                        case "Recepcion":
                            Estados.ModificarEstado("haveCertificate", true);
                            mochilaManager.ActualizarMochila();
                            break;
                        case "CajaHerramientas":
                            Estados.ModificarEstado("haveToolBox", true);
                            mochilaManager.ActualizarMochila();
                            break;
                    }
                    
                }
                else
                {
                    switch (objetoAInteractuar.name)
                    {
                        case "PuertaCasa":
                            if (Estados.DevolverEstado("haveKey"))
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
                            if (Estados.DevolverEstado("haveCertificate"))
                            {
                                if (!Estados.DevolverEstado("primeraCarreraTerminada"))
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
                        case "PuertaTaller":
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
        Estados.ModificarEstado("isHandbrakin", true);
    }

    public void ActualizarReferencias()
    {
        nombreDeEscenaActual = SceneManager.GetActiveScene().name;

        if (nombreDeEscenaActual == "CarreraDeDemolicion" || nombreDeEscenaActual == "SegundaCarreraDemolicion")
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            uiManager = GameObject.Find("UI").GetComponent<UIManager>();
        }

        if (nombreDeEscenaActual == "AventuraGrafica" || nombreDeEscenaActual == "Taller" || nombreDeEscenaActual == "Torneo")
        {
            sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>(); //Si no se busca asi, no funciona.
            dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>(); //Idem linea anterior.
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>(); //Idem linea anterior.
            mochilaManager = GameObject.Find("Mochila").GetComponent<MochilaManager>();
            playerAdventureGraphic = GameObject.Find("Player");
            descripciones = GetComponent<Descripciones>();
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
        }
    }
}
