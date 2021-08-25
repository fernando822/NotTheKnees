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
        //animaciones.road(speed);
    }
    public void SetRotation(float valorInputHorizontal)
    {
        animaciones.direccion(valorInputHorizontal);
        anguloDeRotacion = valorInputHorizontal * directionSpeed;
    }

    public void antibuelco()
    {
        Vector3 eulerAngles = transform.rotation.eulerAngles;

        if (eulerAngles.x < 315 & eulerAngles.x > 45)
        {
            if (eulerAngles.x < 180)
                transform.Rotate(Vector3.right, 45 - eulerAngles.x);
            else
                transform.Rotate(Vector3.right, 315 - eulerAngles.x);
        }

        if (eulerAngles.z < 315 & eulerAngles.z > 45)
        {
            if (eulerAngles.z < 180)
                transform.Rotate(Vector3.forward, 45 - eulerAngles.z);
            else
                transform.Rotate(Vector3.forward, 315 - eulerAngles.z);
        }

    }
    public void FixedUpdate()
    {
        PlayerDemolitionRaceMovement();
        antibuelco();
    }

    public void SetSpeed(float speed) => this.speed = speed; 

    public float GetSpeed() => speed;
}
