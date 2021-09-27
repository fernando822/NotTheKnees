using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;


    int daño;
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
