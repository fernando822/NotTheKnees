using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemolitionRacePlayer : MonoBehaviour
{
    public LogicaMovimientoVehiculo movementScript;
    public Transform playerTransform;
    public HandBreak handBreak;

    void Start()
    {
        movementScript = GetComponent<LogicaMovimientoVehiculo>();
        playerTransform = GetComponent<Transform>();
        handBreak = GetComponent<HandBreak>();
    }
}
