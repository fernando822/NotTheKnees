using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorVida : MonoBehaviour
{
    int VidaACambiar;
    string objetoColision;

    VictoriaDerrota victoriaDerrota;

    public EstadoVehiculo causarDañoP;
    public EstadoVehiculo causarDañoE;

    void Start()
    {
        victoriaDerrota = GameObject.Find("RaceManager").GetComponent<VictoriaDerrota>();
    }

    public void CambiarVida(int VidaACambiar, string objetoColision)
    {
        if (objetoColision == "Player")
            causarDañoP.vida += VidaACambiar;
           

        if (objetoColision =="Enemy")
            causarDañoE.vida += VidaACambiar;

        victoriaDerrota.Vidas();

    }




}
