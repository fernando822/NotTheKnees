using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{
    public EstadoVehiculo EstadoVehiculoP;
    public EstadoVehiculo EstadoVehiculoE1;


    void Start()
    {
        
    }

    public void victoriaDerrota()
    {
        if (EstadoVehiculoP.vida <= 0)
            Debug.Log("Derrota");

        if (EstadoVehiculoE1.vida <= 0 )
            Debug.Log("Victoria");
    }
}
