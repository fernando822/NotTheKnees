using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization;



public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;
    [SerializeField] TextMeshProUGUI mensajeVictoria;
    [SerializeField] GameObject panelVictoria;
    [SerializeField] SceneController sceneController;
    [SerializeField] LocalizedStringTable traduccionesUI;

    /*public bool VidaE = true;
    public bool VidaP = true;*/

    int daño;
    float at, bt, ct;
    Vector3 c;
    void Start()
    {
        mensajeVictoria = GameObject.Find("VictoriaText").GetComponent<TextMeshProUGUI>();
        panelVictoria = GameObject.Find("Fin");
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        panelVictoria.SetActive(false);
    }
    private void FixedUpdate()
    {
        if (estadoVehiculoP.vida <= 0 && !Estados.DevolverEstado("gameOver"))
        {
            mensajeVictoria.text = traduccionesUI.GetTable()["UI.ResultadoCarreraDerrota"].Value;
            Estados.ModificarEstado("gameOver", true);
            panelVictoria.SetActive(true);
            StartCoroutine(cargarEscenaDespuesDe3Segundos("CarreraDeDemolicion"));
            
        }

        if (estadoVehiculoE.vida <= 0 && !Estados.DevolverEstado("gameOver"))
        {
            mensajeVictoria.text = traduccionesUI.GetTable()["UI.ResultadoCarreraVictoria"].Value;
            panelVictoria.SetActive(true);
            Estados.ModificarEstado("primeraCarreraTerminada", true);
            StartCoroutine(cargarEscenaDespuesDe3Segundos("Taller nueva"));
            
        }
    }
    IEnumerator cargarEscenaDespuesDe3Segundos(string sceneName)
    {
        yield return new WaitForSeconds(3);
        sceneController.CargarEscena(sceneName);
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
            }


            if (objetoCollision == estadoVehiculoE.name)
            {
                estadoVehiculoE.RecibirDaño(daño);
            }
        }
    }
}
