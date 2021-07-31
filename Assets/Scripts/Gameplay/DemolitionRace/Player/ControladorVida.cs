using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorVida : MonoBehaviour
{
    int VidaACambiar;
    string objetoColision;

    VictoriaDerrota victoriaDerrota;

    public EstadoVehiculo EstadoVehiculoP;
    public EstadoVehiculo EstadoVehiculoE;

    void Start()
    {
        victoriaDerrota = GameObject.Find("RaceManager").GetComponent<VictoriaDerrota>();
    }

    public void CambiarVida(int VidaACambiar, string objetoColision)
    {
        if (objetoColision == "Player")
            EstadoVehiculoP.vida += VidaACambiar;
           

        if (objetoColision =="Enemy")
            EstadoVehiculoE.vida += VidaACambiar;

        victoriaDerrota.Vidas();

    }




}
