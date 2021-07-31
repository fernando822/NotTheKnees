using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo EstadoVehiculoP;
    public EstadoVehiculo EstadoVehiculoE;
    [SerializeField] Slider slider;

    void Start()
    {
    }

    public void CambiarVida(int vidaACambiar, string objetoCollision)
    {
        if (objetoCollision == "Player")
        {
            EstadoVehiculoP.vida -= vidaACambiar;
            slider.value = EstadoVehiculoP.vida;
        }


        if (objetoCollision == "Enemy")
            EstadoVehiculoE.vida -= vidaACambiar;

    }




}
