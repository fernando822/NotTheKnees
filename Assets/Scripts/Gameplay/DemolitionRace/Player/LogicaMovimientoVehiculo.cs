using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] EstadoVehiculo estadoVehiculo;
    [SerializeField] public float directionSpeed = 30f;
    [SerializeField] float aceleration = 300f;
    [SerializeField] float frenado = 10f;
    [SerializeField] float tolX = 45;
    [SerializeField] float tolZ = 45;

    float speed;
    float freno;
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

        ruedaAdelanteDerecha.brakeTorque = freno;
        ruedaAdelanteIzquierda.brakeTorque = freno;
        ruedaAtrasDerecha.brakeTorque = freno;
        ruedaAtrasIzquierda.brakeTorque = freno;

        ruedaAdelanteDerecha.steerAngle = anguloDeRotacion;
        ruedaAdelanteIzquierda.steerAngle = anguloDeRotacion;
    }

    public void Accelerate(float valorInputVertical)
    {
            speed = aceleration * valorInputVertical;

        if (valorInputVertical == 0)
            freno = frenado;
        else
            freno = 0;
    }
    public void SetRotation(float valorInputHorizontal)
    {
        anguloDeRotacion = valorInputHorizontal * directionSpeed;
        animaciones.direccion(anguloDeRotacion);
    }

    public void antibuelco()
    {
        Vector3 eulerAngles = transform.rotation.eulerAngles;

        eulerAngles.x = (eulerAngles.x > 180) ? eulerAngles.x - 360 : eulerAngles.x;
        eulerAngles.z = (eulerAngles.z > 180) ? eulerAngles.z - 360 : eulerAngles.z;

        if ((eulerAngles.x < -tolX || eulerAngles.x > tolX) || (eulerAngles.z < -tolZ || eulerAngles.z > tolZ))
        {
            eulerAngles.x = Mathf.Clamp(eulerAngles.x, -tolX, tolX);
            eulerAngles.z = Mathf.Clamp(eulerAngles.z, -tolZ, tolZ);

            transform.rotation = Quaternion.Euler(eulerAngles);
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
