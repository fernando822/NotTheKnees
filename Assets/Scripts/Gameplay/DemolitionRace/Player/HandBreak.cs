using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBreak : MonoBehaviour
{
    LogicaMovimientoVehiculo logicaMovimientoVehiculo;


    
    private void Start()
    {
        logicaMovimientoVehiculo = GetComponent<LogicaMovimientoVehiculo>();
    }

    public void HandBrake()
    {
        logicaMovimientoVehiculo.SetSpeed(0);
    }
}
