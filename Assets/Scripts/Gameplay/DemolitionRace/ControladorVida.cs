using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;
    [SerializeField] TextMeshProUGUI mensajeVictoria;
    [SerializeField] GameObject panelVictoria;
    [SerializeField] SceneController sceneController;

    public bool VidaE = true;
    public bool VidaP = true;
    bool gameOver = false;

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
        if (estadoVehiculoP.vida <= 0 && !gameOver)
        {
            mensajeVictoria.text = "YOU LOSE!";
            VidaP = false;
            panelVictoria.SetActive(true);
            StartCoroutine("esperarTresSeg");
            sceneController.CargarEscena("CarreraDeDemolicion");


        }

        if (estadoVehiculoE.vida <= 0 && !gameOver)
        {
            mensajeVictoria.text = "YOU WIN!";
            VidaE = false;
            panelVictoria.SetActive(true);
            Estados.ModificarEstado("primeraCarreraTerminada", true);
            StartCoroutine("esperarTresSeg");
            sceneController.CargarEscena("Taller");


        }
    }
    IEnumerator esperarTresSeg()
    {
        gameOver = true;
        yield return new WaitForSeconds(3f);
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
