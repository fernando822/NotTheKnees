using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaMovimientoVehiculo : MonoBehaviour
{
    [SerializeField] DemolitionRacePlayer player;
    [SerializeField] public float anguloDireccion = 30f;
    [SerializeField] float aceleration = 300f;
    [SerializeField] float frenado = 10f;
    [SerializeField] float tolX = 45;
    [SerializeField] float tolZ = 45;
    [SerializeField] float turboBoost = 2;

    public float torque;
    float direccion;
    float freno;
    float rpm, a, b, c, d;

    public bool Turbo;
    float turboActual;

    [SerializeField] WheelCollider ruedaAdelanteIzquierda;
    [SerializeField] WheelCollider ruedaAdelanteDerecha;
    [SerializeField] WheelCollider ruedaAtrasIzquierda;
    [SerializeField] WheelCollider ruedaAtrasDerecha;

    public animaciones animaciones;

    private void Start()
    {
    }

    public void ControlRuedas()
    {
        ruedaAdelanteDerecha.motorTorque = torque;
        ruedaAdelanteIzquierda.motorTorque = torque;
        ruedaAtrasDerecha.motorTorque = torque;
        ruedaAtrasIzquierda.motorTorque = torque;

        ruedaAdelanteDerecha.brakeTorque = freno;
        ruedaAdelanteIzquierda.brakeTorque = freno;
        ruedaAtrasDerecha.brakeTorque = freno;
        ruedaAtrasIzquierda.brakeTorque = freno;

        ruedaAdelanteDerecha.steerAngle = direccion;
        ruedaAdelanteIzquierda.steerAngle = direccion;
    }

    public void Accelerate(float valorInputVertical)
    {
        turboActual = (Turbo == true) ? turboActual = turboBoost : turboActual = 1;

            torque = aceleration * valorInputVertical * turboActual;

        if (valorInputVertical == 0)
            freno = frenado;
        else
            freno = 0;

        a = ruedaAdelanteDerecha.rpm;
        b = ruedaAdelanteIzquierda.rpm;
        c = ruedaAtrasDerecha.rpm;
        d = ruedaAtrasIzquierda.rpm;
        rpm = (float)(a + b + c + d) / 4;
        player.animaciones.rotacion(rpm);
    }
    public void SetRotation(float valorInputHorizontal)
    {
        direccion = valorInputHorizontal * anguloDireccion;
        player.animaciones.direccion(direccion);
    }

    public void antibuelco()
    {
        Vector3 eulerAngles = player.transform.rotation.eulerAngles;

        eulerAngles.x = (eulerAngles.x > 180) ? eulerAngles.x - 360 : eulerAngles.x;
        eulerAngles.z = (eulerAngles.z > 180) ? eulerAngles.z - 360 : eulerAngles.z;

        if ((eulerAngles.x < -tolX || eulerAngles.x > tolX) || (eulerAngles.z < -tolZ || eulerAngles.z > tolZ))
        {
            eulerAngles.x = Mathf.Clamp(eulerAngles.x, -tolX, tolX);
            eulerAngles.z = Mathf.Clamp(eulerAngles.z, -tolZ, tolZ);

            player.transform.rotation = Quaternion.Euler(eulerAngles);
        }
    } 
    public void FixedUpdate()
    {
        ControlRuedas();
        antibuelco();
    }

    public void SetSpeed(float speed) => this.torque = speed; 

    public float GetSpeed() => torque;
}
