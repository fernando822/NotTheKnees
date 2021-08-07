using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBreak : MonoBehaviour
{
    LogicaMovimientoVehiculo logicaMovimientoVehiculo;

    [SerializeField] float handBrake = 50;

    
    private void Start()
    {
        logicaMovimientoVehiculo = GameObject.Find("Player").GetComponent<LogicaMovimientoVehiculo>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            logicaMovimientoVehiculo.SetSpeed(Mathf.Lerp(logicaMovimientoVehiculo.GetSpeed(), 0, handBrake * Time.deltaTime));
    }
}
