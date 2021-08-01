using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGraphicMovement : MonoBehaviour
{
    [SerializeField] AdventureGraphicPlayer player;
    [SerializeField] float movementSpeed;

    float newVerticalPosition;
    float newHorizontalPosition;

    void start()
    {
        player = GetComponent <AdventureGraphicPlayer>();

    }

    void FixedUpdate()
    {
        graphicAdventurePlayerMovement();
    }


    private void graphicAdventurePlayerMovement()
    {
        player.playerTransform.position += Vector3.right * newHorizontalPosition * movementSpeed * Time.fixedDeltaTime;
        player.playerTransform.position += Vector3.forward * newVerticalPosition * movementSpeed * Time.fixedDeltaTime;


    }

    public void SetNewHorizontalPosition(float position)
    {
        this.newHorizontalPosition = position;
    }

    public void SetNewVerticalPosition(float position)
    {
        this.newVerticalPosition = position;
    }
}

