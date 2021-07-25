using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    float directionSpeed = 30f;
    float aceleration = 30f;
    float speedLimit = 70f;
    float speed = 0f;
    float direccionInputHorizontal;
    float direccionInputVertical;
    float drag = 1f;

    private void Start()
    {
    }

    public void PlayerDemolitionRaceMovement()
    {
        speed = Mathf.Clamp(speed, -speedLimit * 0.4f, speedLimit);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void SetSpeed()
    {
        
        if (direccionInputVertical != 0)
        {
            speed += Time.deltaTime * aceleration * direccionInputVertical;
        }
        else
        {
            speed = Mathf.Lerp(speed, 0, drag * Time.deltaTime);
        }
    }

    void Rotate()
    {
        float anguloDeRotacion = direccionInputHorizontal * Time.deltaTime * directionSpeed * direccionInputVertical;
        transform.Rotate(Vector3.up, anguloDeRotacion);
        
    }
    public void PlayerDemolitionRaceHandBrake()
    {

    }

    public void PlayerDemolitionRaceTurbo()
    {
        



    }

    public void FixedUpdate()
    {
        direccionInputVertical = Input.GetAxis("Vertical");
        direccionInputHorizontal = Input.GetAxis("Horizontal");
        SetSpeed();
        PlayerDemolitionRaceMovement();
        Rotate();
    }

}
