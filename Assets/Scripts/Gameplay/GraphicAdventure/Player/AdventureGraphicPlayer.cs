using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGraphicPlayer : MonoBehaviour
{
    public AdventureGraphicMovement movementScript;
    public Transform playerTransform;
    GameManager gameManager;

    void start()
    {
        this.gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        this.movementScript = GetComponent<AdventureGraphicMovement>();
        this.playerTransform = GetComponent<Transform>();
    }

}
