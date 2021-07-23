using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGraphicMovement : MonoBehaviour
{
    [SerializeField] AdventureGraphicPlayer player;
    [SerializeField] float walkingSpeed;

    public float movementSpeed = 0;
    float newVerticalPosition;
    float horizontalVelocity;
    float verticalVelocity;

    void start()
    {
        player = GetComponent <AdventureGraphicPlayer> ();

        this.verticalVelocity = 0;
        this.horizontalVelocity = 0;

    }

    void FixedUpdate()
    {
        graphicAdventurePlayerMovement();
    }

    void setMovementVelocity()
    {
        horizontalVelocity = newVerticalPosition * walkingSpeed;
    }

    private void graphicAdventurePlayerMovement()
    {

        var movementVector = new Vector3(horizontalVelocity * Time.fixedDeltaTime, verticalVelocity * Time.fixedDeltaTime);
        player.playerTransform.Translate(movementVector, Space.World);

    }

    public void SetNewHorizontalPosition(float position)
    {
        this.newVerticalPosition = position;
    }
}
