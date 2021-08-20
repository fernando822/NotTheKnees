using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGraphicPlayer : MonoBehaviour
{
    public AdventureGraphicMovement movementScript;
    public Transform playerTransform;
    public PuedeInteractuar puedeInteractuar;


    void Start()
    {
        movementScript = GetComponent<AdventureGraphicMovement>();
        playerTransform = GetComponent<Transform>();
        puedeInteractuar = GetComponent<PuedeInteractuar>();
        
    }

}
