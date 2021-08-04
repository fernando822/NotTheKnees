using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorVida : MonoBehaviour
{

    VictoriaDerrota victoriaDerrota;

    public EstadoVehiculo EstadoVehiculoP;
    public EstadoVehiculo EstadoVehiculoE;

    [SerializeField] Slider slider;

    void Start()
    {
        victoriaDerrota = GameObject.Find("GameManager").GetComponent<VictoriaDerrota>();
    }

    public void CambiarVida(int vidaACambiar, string objetoCollision)
    {
        if (objetoCollision == "Player")
        {
            EstadoVehiculoP.vida -= vidaACambiar;
            
        }


        if (objetoCollision == "Enemy")
        {
            EstadoVehiculoE.vida -= vidaACambiar;
        }
        victoriaDerrota.victoriaDerrota();
    }




}
