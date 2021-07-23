using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    private AdventureGraphicPlayer player;

    private void Start()
    {
        player = GameObject.Find("PlayerGraphicAdventure").GetComponent<AdventureGraphicPlayer>();
    }

    public void PlayerMove(Vector2 nuevaPosicion)
    {
        player.movementScript.SetNewHorizontalPosition(nuevaPosicion.x);
    }

    public void PlayerAction()
    {
        
    }

    public void PlayerShowKeyObjects()
    {
        
    }

    public void PlayerMenu()
    {
        
    }

}
