using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] float directionSpeed = 0.1f;
    [SerializeField] float aceleration = 30f;
    [SerializeField] float speedLimit = 70f;
    [SerializeField] float drag = 1f;

    float speed;

    public animaciones animaciones;


    private void Start()
    {
        player = GetComponent<DemolitionRacePlayer>();
    }

    public void PlayerDemolitionRaceMovement()
    {
        speed = Mathf.Clamp(speed, -speedLimit * 0.4f, speedLimit);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        animaciones.road(speed);
    }

    public void SetSpeedAndRotation(float direccionInputHorizontal, float direccionInputVertical)
    {
        animaciones.direccion(direccionInputHorizontal);
        

        if (direccionInputVertical != 0)
        {
            speed += Time.deltaTime * aceleration * direccionInputVertical;
        }
        else
        {
            speed = Mathf.Lerp(speed, 0, drag * Time.deltaTime);
        }

        float anguloDeRotacion = direccionInputHorizontal * Time.deltaTime * directionSpeed * speed;
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
        PlayerDemolitionRaceMovement();    
    }

    public void SetSpeed(float speed) => this.speed = speed;

    public float GetSpeed() => speed;
}
