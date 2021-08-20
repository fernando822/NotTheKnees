using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] EstadoVehiculo estadoVehiculo;
    [SerializeField] float directionSpeed = 0.1f;
    [SerializeField] float aceleration = 30f;
    [SerializeField] float drag = 2f;

    float speed;
    float anguloDeRotacion;
    [SerializeField] WheelCollider ruedaAdelanteIzquierda;
    [SerializeField] WheelCollider ruedaAdelanteDerecha;
    [SerializeField] WheelCollider ruedaAtrasIzquierda;
    [SerializeField] WheelCollider ruedaAtrasDerecha;
    public animaciones animaciones;


    private void Start()
    {
        player = GetComponent<DemolitionRacePlayer>();
        estadoVehiculo = GetComponent<EstadoVehiculo>();
    }

    public void PlayerDemolitionRaceMovement()
    {
        ruedaAdelanteDerecha.motorTorque = speed;
        ruedaAdelanteIzquierda.motorTorque = speed;
        ruedaAtrasDerecha.motorTorque = speed;
        ruedaAtrasIzquierda.motorTorque = speed;

        ruedaAdelanteDerecha.steerAngle = anguloDeRotacion;
        ruedaAdelanteIzquierda.steerAngle = anguloDeRotacion;
       
    }

    public void Accelerate(float valorInputVertical)
    {
        if (valorInputVertical != 0 && 
            (ruedaAdelanteDerecha.isGrounded || ruedaAdelanteIzquierda.isGrounded) 
            && !GameManager.isHandBraking)
        {
            speed = aceleration * valorInputVertical;
        }
        else
        {
            speed = Mathf.Lerp(speed, 0, drag);
        }

    }
    public void SetRotation(float valorInputHorizontal)
    {
        animaciones.direccion(valorInputHorizontal);
        anguloDeRotacion = valorInputHorizontal * directionSpeed;
    }

    public void FixedUpdate()
    {
        PlayerDemolitionRaceMovement();
    }

    public void SetSpeed(float speed) => this.speed = speed; 

    public float GetSpeed() => speed;
}
