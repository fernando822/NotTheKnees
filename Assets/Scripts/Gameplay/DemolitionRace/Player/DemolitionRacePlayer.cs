using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemolitionRacePlayer : MonoBehaviour
{
    public Transform playerTransform;
    public LogicaMovimientoVehiculo movementScript;
    public HandBreak handBreak;
    public animaciones animaciones;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
        movementScript = GetComponent<LogicaMovimientoVehiculo>();
        handBreak = GetComponent<HandBreak>();
        animaciones = GetComponent<animaciones>();
    }
}
