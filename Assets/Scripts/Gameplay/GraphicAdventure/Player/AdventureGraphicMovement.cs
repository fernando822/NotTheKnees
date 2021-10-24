using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGraphicMovement : MonoBehaviour
{
    [SerializeField] AdventureGraphicPlayer player;
    [SerializeField] float movementSpeed;
    [SerializeField] float suavidadRotacion;
    [SerializeField] Animator animator;

    float newVerticalPosition;
    float newHorizontalPosition;
    Vector3 newPositionLerp = new Vector3(0, 0, 0);
    void Start()
    {
        player = GetComponent<AdventureGraphicPlayer>();
        animator = GetComponent<Animator>();
             
    }

    void FixedUpdate()
    {
        graphicAdventurePlayerMovement();
        handlePlayerRotation();
    }


    private void graphicAdventurePlayerMovement()
    {
        if (newHorizontalPosition != 0f|| newVerticalPosition != 0f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        player.playerTransform.position += Vector3.right * newHorizontalPosition * movementSpeed * Time.fixedDeltaTime;
        player.playerTransform.position += Vector3.forward * newVerticalPosition * movementSpeed * Time.fixedDeltaTime;

    }
    private void handlePlayerRotation()
    {
        Vector3 currentPosition = transform.position;

        Vector3 newPosition = new Vector3(newHorizontalPosition, 0, newVerticalPosition);
        newPosition.Normalize();

        if (newHorizontalPosition != 0 || newVerticalPosition != 0)
        {
            newPositionLerp.x = Mathf.Lerp(newPositionLerp.x, newPosition.x, suavidadRotacion);
            newPositionLerp.z = Mathf.Lerp(newPositionLerp.z, newPosition.z, suavidadRotacion);

            Vector3 positionToLookAt = currentPosition + newPositionLerp;

            transform.forward = newPositionLerp;
        }
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

