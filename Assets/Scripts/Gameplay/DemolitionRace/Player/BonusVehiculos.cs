using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusVehiculos : MonoBehaviour
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
            logicaMovimientoVehiculo.speed = Mathf.Lerp(logicaMovimientoVehiculo.speed, 0, handBrake * Time.deltaTime);
    }
}
