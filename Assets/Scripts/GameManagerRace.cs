using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRace : MonoBehaviour
{
    private DemolitionRacePlayer player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<DemolitionRacePlayer>();
       

    }




    public void PlayerDemolitionRaceMovement(Vector2 value)
    {
        player.movementScript.SetSpeedAndRotation(value.x, value.y);
    }

    public void PlayerDemolitionRaceHandBrake()
    {

    }

    public void PlayerDemolitionRaceTurbo()
    {

    }

}
