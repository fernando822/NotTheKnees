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
    public static int indexLocale;
    public static int karma;
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
    MusicaFondo musicaFondo;


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
        indexLocale = 0;
        karma = 0;
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
        Estados.AgregarEstado("madeChoice", false);
        Estados.AgregarEstado("vehiculoSaboteado", false);
        Estados.AgregarEstado("isPaused", false);
    }
    public void PlayerMove(Vector2 nuevaPosicion)
    {
        scriptPlayerAdventureGraphic.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
        scriptPlayerAdventureGraphic.movementScript.SetNewVerticalPosition(nuevaPosicion.y);
    }

    public void PlayerAction()
    {
        if (!Estados.DevolverEstado("isUiOpen") && !Estados.DevolverEstado("inMenu"))
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

                dialogueManager.Controlador(objetoAInteractuar.name);
                
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
        if(!nombreDeEscenaActual.Contains("Menu") && !nombreDeEscenaActual.Contains("Cinematica"))
        {
            Estados.ModificarEstado("isPaused", !Estados.DevolverEstado("isPaused"));
        }
    }

    public void ToggleBackpack()
    {
        uiManager.ToggleBackpack();
    }
    public void ToggleMap()
    {
        uiManager.ToggleMap();
    }

    public void ToggleChoices()
    {
        uiManager.ToggleChoices();
    }
    public void ActualizarMochila()
    {
        mochilaManager.ActualizarMochila();
    }
    public void LimpiarTexto()
    {
        dialogueManager.ClearText();
    }
    public void CargarEscena(string sceneName)
    {
        sceneController.CargarEscena(sceneName);
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
    public void CambiarMusica()
    {
        musicaFondo.CambiarMusica(nombreDeEscenaActual);
    }
    public void ActualizarReferencias()
    {
        nombreDeEscenaActual = SceneManager.GetActiveScene().name;
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        inputPlayer = GetComponent<InputPlayer>();
        inputPlayerDemolitionRace = GetComponent<InputPlayerDemolitionRace>();
        musicaFondo = GetComponent<MusicaFondo>();

        if (nombreDeEscenaActual.Contains("Carrera"))
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            controladorVida = GameObject.Find("LifeController").GetComponent<ControladorVida>();
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();

            controladorVida.ActualizarControladorVida();
            inputPlayerDemolitionRace.enabled = true;
        }
        else
        {
            inputPlayerDemolitionRace.enabled = false;
        }

        if (nombreDeEscenaActual == "AventuraGrafica" || nombreDeEscenaActual == "Taller" || nombreDeEscenaActual == "Torneo")
        {
            inputPlayer.enabled = true;
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
            dialogueManager = GameObject.Find("DialogueManager").GetComponent<DialogueManager>();
            mochilaManager = GameObject.Find("Mochila").GetComponent<MochilaManager>();
            mapController = GameObject.Find("Map").GetComponent<MapController>();
            playerAdventureGraphic = GameObject.Find("Player");
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
        }
        else
        {
            inputPlayer.enabled = false;
        }
    }
    

}
