using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    private DemolitionRacePlayer playerDemolitionRace;
    private GameObject playerAdventureGraphic;
    public static string nombreDeEscenaActual;
    private AdventureGraphicPlayer scriptPlayerAdventureGraphic;
    [SerializeField] SceneController sceneController;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] UIManager uiManager;
    [SerializeField] MochilaManager mochilaManager;
    [SerializeField] MapController mapController;
    ControladorVida controladorVida;
    SpawnTurbo spawnTurbo;
    InputPlayerDemolitionRace inputPlayerDemolitionRace;
    InputPlayer inputPlayer;


    private void Awake()
    {
        if (GM != null)
            GameObject.Destroy(GM);
        else
            GM = this;

        DontDestroyOnLoad(this);
        ActualizarReferencias();
        AgregarEstados();

    }
    public void Start()
    {
        
    }
    private void AgregarEstados()
    {
        Estados.estados = new Dictionary<string, bool>();
        Estados.AgregarEstado("isHandBraking", false);
        Estados.AgregarEstado("isUiOpen", true);
        Estados.AgregarEstado("dialogueOngoing", false);
        Estados.AgregarEstado("haveKey", false);
        Estados.AgregarEstado("haveCertificate", false);
        Estados.AgregarEstado("haveToolBox", false);
        Estados.AgregarEstado("checkedCar", false);
        Estados.AgregarEstado("primeraCarreraTerminada", false);
        Estados.AgregarEstado("segundaCarreraTerminada", false);
        Estados.AgregarEstado("primeraVezEnPrimeraEscena", true);
        Estados.AgregarEstado("inMenu", true);
        Estados.AgregarEstado("gameOver", false);
    }
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        scriptPlayerAdventureGraphic.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        scriptPlayerAdventureGraphic.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        if (!Estados.DevolverEstado("isUiOpen"))
        {
            if (PuedeInteractuar.interactuable)
            {
                GameObject objetoAInteractuar = DecidirObjetoInteractuable.ObjetoMasCercano(
                scriptPlayerAdventureGraphic.puedeInteractuar.GetGameObjects(), playerAdventureGraphic);

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
                    case "PuertaCasa":
                        if (Estados.DevolverEstado("haveKey"))
                        {
                            dialogueManager.ClearText();
                            ToggleMap();
                            break;
                        }
                        break;
                    case "PuertaEmpezarCarrera":
                        if (Estados.DevolverEstado("haveCertificate"))
                        {
                            dialogueManager.ClearText();
                            if (!Estados.DevolverEstado("primeraCarreraTerminada"))
                            {
                                sceneController.CargarEscena("CarreraDeDemolicion");
                                break;
                            }
                            if(!Estados.DevolverEstado("segundaCarreraTerminada"))
                            {
                                sceneController.CargarEscena("SegundaCarreraDemolicion");
                                break;
                            }
                            else
                            {
                                sceneController.CargarEscena("TerceraCarreraDemolicion");
                                break;
                            }
                        }
                        break;
                    case "PuertaEntradaTorneo":
                        dialogueManager.ClearText();
                        ToggleMap();
                        break;
                    case "PuertaTaller":
                        dialogueManager.ClearText();
                        ToggleMap();
                        break;
                    case "CajaHerramientas":
                        Estados.ModificarEstado("haveToolBox", true);
                        break;
                    case "Elevador":
                        Estados.ModificarEstado("checkedCar", true);
                        break;
                    default:
                        
                        break;
                }
            }
            else
            {
                if (!Estados.DevolverEstado("inMenu"))
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
        Estados.ModificarEstado("isHandbraking", true);
    }

    public void ActualizarReferencias()
    {
        nombreDeEscenaActual = SceneManager.GetActiveScene().name;
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        inputPlayer = GetComponent<InputPlayer>();
        inputPlayerDemolitionRace = GetComponent<InputPlayerDemolitionRace>();

        if (nombreDeEscenaActual.Contains("Carrera"))
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            controladorVida = GameObject.Find("LifeController").GetComponent<ControladorVida>();
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();

            controladorVida.ActualizarControladorVida();
            inputPlayerDemolitionRace.enabled = true;
            inputPlayer.enabled = false;
        }
        else
        {
            inputPlayerDemolitionRace.enabled = false;
            inputPlayer.enabled = true;
        }

        if (nombreDeEscenaActual == "AventuraGrafica" || nombreDeEscenaActual == "Taller" || nombreDeEscenaActual == "Torneo")
        {
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
            mochilaManager = GameObject.Find("Mochila").GetComponent<MochilaManager>();
            mapController = GameObject.Find("Map").GetComponent<MapController>();
            playerAdventureGraphic = GameObject.Find("Player");
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
        }
    }
}
