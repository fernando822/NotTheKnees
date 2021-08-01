using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    public float speed = 0;
    [SerializeField] float aceleration = 30;
    [SerializeField] float speedLimit = 70;
    [SerializeField] float drag = 1;
    [SerializeField] float directionSpeed = 2;
    [SerializeField] float direccionInputHorizontal;
    [SerializeField] float direccionInputVertical;

    private void Start()
    {
    }

    public void PlayerDemolitionRaceMovement()
    {
        speed = Mathf.Clamp(speed, -speedLimit * 0.5f, speedLimit);
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
        float anguloDeRotacion = direccionInputHorizontal * Time.deltaTime * directionSpeed * speed;
        transform.Rotate(Vector3.up, anguloDeRotacion);
        
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
