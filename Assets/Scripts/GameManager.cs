using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    private DemolitionRacePlayer playerDemolitionRace;
    private GameObject playerAdventureGraphic;

    public static bool tieneLlave = false;
    public static bool interactuoConNPC = false;
    public static bool isHandBraking = false;


    private Descripciones descripciones;
    private AdventureGraphicPlayer scriptPlayerAdventureGraphic;
    [SerializeField] SceneController cambioDeNivel;
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;
    [SerializeField] UIManager uiManager;
    [SerializeField] MochilaManager mochilaManager;

    private void Awake()
    {
        if (GM != null)
            GameObject.Destroy(GM);
        else
            GM = this;
            DontDestroyOnLoad(this);
       
            
    }
    private void Start()
    {

        if (SceneManager.GetActiveScene().name == "CarreraDeDemolicion")
        {
            playerDemolitionRace = GameObject.Find("PlayerDemolitionRace").GetComponent<DemolitionRacePlayer>();
            uiManager = GameObject.Find("UI").GetComponent<UIManager>();
        }

        if(SceneManager.GetActiveScene().name == "AventuraGrafica")
        {
            cambioDeNivel = GameObject.Find("SceneManager").GetComponent<SceneController>(); //Si no se busca asi, no funciona.
            uiManager = GameObject.Find("UIManager").GetComponent<UIManager>(); //Idem linea anterior.
            mochilaManager = GameObject.Find("MochilaManager").GetComponent<MochilaManager>();
            playerAdventureGraphic = GameObject.Find("Player");
            descripciones = GetComponent<Descripciones>();
            scriptPlayerAdventureGraphic = playerAdventureGraphic.GetComponent<AdventureGraphicPlayer>();
            mostrarTexto = GetComponent<MostrarTexto>();
            objetoRecogido = GetComponent<ObjetoRecogido>();
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
                case "NPC":
                    mostrarTexto.ShowText("Romero, el NPC perdido", DialogoNPC.DialogoDelNPC(tieneLlave));
                    interactuoConNPC = true;
                    break;

                case "Mesa de luz":
                    mostrarTexto.ShowTextProtagonista(DescripcionMesaDeLuz.DescripcionDeLaMesaDeLuz(tieneLlave));
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
                        Destroy(this.gameObject);
                    }
                    else
                    {
                        mostrarTexto.ShowTextProtagonista(DescripcionPuerta.DescripcionDeLaPuerta(tieneLlave));
                    }
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

    public void ShowDescriptionOfObtainedObject()
    {
        if (tieneLlave)
        {
            mostrarTexto.ShowTextProtagonista(ObtenerDescripcion());
        }
        else
        {
            mostrarTexto.ShowTextProtagonista("No tengo ningún objeto aún.");
        }
    }

    string ObtenerDescripcion()
    {
        return objetoRecogido.MostrarDescripcion();
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

    public void OpenMochila()
    {
        mochilaManager.TogglePanel();
    }

}
