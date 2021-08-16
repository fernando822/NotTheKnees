using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    public LogicaMovimientoVehiculo logicaMovimientoVehiculo;

    void Update()
    {
        
    }

    private void Start()
    {
        direccion();
    }
    void direccion()
    {
        transform.Rotate(Vector3.up, 1);
    }



}

