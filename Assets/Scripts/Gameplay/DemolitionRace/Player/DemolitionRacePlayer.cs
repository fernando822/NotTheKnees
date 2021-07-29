using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemolitionRacePlayer : MonoBehaviour
{
    public LogicaMovimientoVehiculo movementScript;
    public Transform playerTransform;
    GameManagerRace gameManager;

    void start()
    {
        this.gameManager = GameObject.Find("GameManager").GetComponent<GameManagerRace>();
        this.movementScript = GetComponent<LogicaMovimientoVehiculo>();
        this.playerTransform = GetComponent<Transform>();
    }
}
