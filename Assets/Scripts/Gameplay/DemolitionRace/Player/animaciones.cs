using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    public LogicaMovimientoVehiculo logicaMovimientoVehiculo;

    float deseada, actual;

    void Update()
    {
        //direccion();
    }

    private void Start()
    {
        direccion();
    }
    void direccion()
    {
        //logicaMovimientoVehiculo.direccionInputHorizontal


        transform.RotateAround(Vector3.up, 90);
    }



}

