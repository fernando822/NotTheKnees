using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;
    [SerializeField] Slider slider;

    float at, bt, ct;
    Vector3 c;

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

    public void CambiarVida(Vector3 a, Vector3 b, string objetoCollision)
    {
        at = a.magnitude;
        bt = b.magnitude;

        if (at > bt)
        {
            c = a - b;
            ct = c.magnitude;

            if (objetoCollision == "Player")
            {
                estadoVehiculoP.vida -= (int)ct;
                slider.value = estadoVehiculoP.vida;
            }


            if (objetoCollision == "Enemy")
            {
                estadoVehiculoE.vida -= (int)ct;
            }


        }
    }




}
