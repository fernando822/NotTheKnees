using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.UI;



public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;
    Slider barraSaludPlayer;
    Slider barraSaludEnemigo;
    int carreraCompletada;
    [SerializeField] TextMeshProUGUI mensajeVictoria;
    [SerializeField] GameObject panelVictoria;
    [SerializeField] SceneController sceneController;
    [SerializeField] LocalizedStringTable traduccionesUI;

    

    int daño;
    float at, bt, ct;
    Vector3 c;
    void Awake()
    {
        ActualizarControladorVida();
    }
    public void ActualizarControladorVida()
    {
        estadoVehiculoP = GameObject.FindGameObjectWithTag("Player").GetComponent<EstadoVehiculo>();
        estadoVehiculoE = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EstadoVehiculo>();
        barraSaludPlayer = GameObject.Find("BarraDeVida").GetComponent<Slider>();
        barraSaludEnemigo = GameObject.Find("BarraVidaEnemigo").GetComponent<Slider>();
        panelVictoria = GameObject.Find("Fin");
        mensajeVictoria = GameObject.Find("VictoriaText").GetComponent<TextMeshProUGUI>();
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        barraSaludPlayer.value = estadoVehiculoP.vida;
        if (Estados.DevolverEstado("vehiculoSaboteado"))
        {
            estadoVehiculoE.vida /= 2;
            Estados.ModificarEstado("vehiculoSaboteado", false);
        }
        barraSaludEnemigo.value = estadoVehiculoE.vida;
    }
    private void Start()
    {
        panelVictoria.SetActive(false);

    }
    private void FixedUpdate()
    {
        if (GameManager.nombreDeEscenaActual.Contains("Carrera"))
        {
            switch (GameManager.nombreDeEscenaActual)
            {
                case "CarreraDeDemolicion":
                    Derrota("CarreraDeDemolicion");
                    Victoria("Torneo");
                    break;
                case "SegundaCarreraDemolicion":
                    Derrota("SegundaCarreraDemolicion");
                    Victoria("Torneo");
                    break;
                case "TerceraCarreraDemolicion":
                    Derrota("TerceraCarreraDemolicion");
                    switch (GameManager.karma)
                    {
                        case 0:
                            Victoria("CinematicaFinalBueno");
                            break;
                        case 1:
                            Victoria("CinematicaFinalNeutro");
                            break;
                        case 2:
                            Victoria("CinematicaFinalMalo");
                            break;
                        case 3:
                            Victoria("CinematicaFinalPesimo");
                            break;
                        default:
                            Victoria("CinematicaTorneo");
                            break;
                    }
                    break;
            }
        }
    }
    IEnumerator cargarEscenaDespuesDe3Segundos(string sceneName)
    {
        yield return new WaitForSeconds(3);
        sceneController.CargarEscena(sceneName);
    }
    public void Derrota(string sceneName)
    {
        if (estadoVehiculoP.vida <= 0 && !Estados.DevolverEstado("gameOver"))
        {
            mensajeVictoria.text = traduccionesUI.GetTable()["UI.ResultadoCarreraDerrota"].Value;
            Estados.ModificarEstado("gameOver", true);
            panelVictoria.SetActive(true);
            StartCoroutine(cargarEscenaDespuesDe3Segundos(sceneName));
        }
    }
    public void Victoria(string sceneName)
    {
        if (estadoVehiculoE.vida <= 0 && !Estados.DevolverEstado("gameOver"))
        {
            mensajeVictoria.text = traduccionesUI.GetTable()["UI.ResultadoCarreraVictoria"].Value;
            panelVictoria.SetActive(true);
            switch (GameManager.nombreDeEscenaActual)
            {
                case "CarreraDeDemolicion":
                    Estados.ModificarEstado("primeraCarreraTerminada", true);
                    break;
                case "SegundaCarreraDemolicion":
                    Estados.ModificarEstado("segundaCarreraTerminada", true);
                    break;
            }
            StartCoroutine(cargarEscenaDespuesDe3Segundos(sceneName));
        }
    }


    public void CambiarVida(Vector3 a, Vector3 b, string objetoCollision, int attack)
    {
        at = a.magnitude;
        bt = b.magnitude;

        if (at > bt)
        {
            c = a - b;
            ct = c.magnitude;

            daño = (int)ct * attack;

            if (objetoCollision == estadoVehiculoP.tag)
            {
                estadoVehiculoP.RecibirDaño(daño);
                barraSaludPlayer.value = estadoVehiculoP.vida;
            }


            if (objetoCollision == estadoVehiculoE.name)
            {
                estadoVehiculoE.RecibirDaño(daño);
                barraSaludEnemigo.value = estadoVehiculoE.vida;
            }
        }
    }
}
