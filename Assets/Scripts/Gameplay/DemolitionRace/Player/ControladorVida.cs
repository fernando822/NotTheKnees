using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;
    [SerializeField] Slider slider;

    private void Update()
    {
        if (estadoVehiculoP.vida <= 0)
        {
            Destroy(estadoVehiculoP.gameObject);

        }
        if(estadoVehiculoE.vida <= 0)
        {
            Destroy(estadoVehiculoE.gameObject);
        }
    }
    void Start()
    {
    }

    public void CambiarVida(int vidaACambiar, string objetoCollision)
    {

        if (objetoCollision == "Player")
        {
            estadoVehiculoP.vida -= vidaACambiar;
            slider.value = estadoVehiculoP.vida;
        }


        if (objetoCollision == "Enemy")
            estadoVehiculoE.vida -= vidaACambiar;

    }




}
