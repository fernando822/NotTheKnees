using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov2 : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    Vector3 vector;
    float angle;

    public float anguloDireccion = 30f;
    public float multiplicador = 1f;
    public float aceleration = 300f;
    public float frenado = 10f;

    [SerializeField] float tolX = 45;
    [SerializeField] float tolZ = 45;

    public float torque;
    float direccion;
    float freno;
    float delanteatras;
    float rpm, a, b, c, d;

 


    [SerializeField] WheelCollider ruedaAdelanteIzquierda;
    [SerializeField] WheelCollider ruedaAdelanteDerecha;
    [SerializeField] WheelCollider ruedaAtrasIzquierda;
    [SerializeField] WheelCollider ruedaAtrasDerecha;

    public animaciones animaciones;

    public void FixedUpdate()
    {
        ControlRuedas();
        antibuelco();
        Accelerate();
        ApuntarPlayer();
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

    public void Accelerate()
    {
        delanteatras = (-90 < angle & angle < 90) ? delanteatras = 1 : delanteatras = -1;

        torque = aceleration * delanteatras;

        a = ruedaAdelanteDerecha.rpm;
        b = ruedaAdelanteIzquierda.rpm;
        c = ruedaAtrasDerecha.rpm;
        d = ruedaAtrasIzquierda.rpm;
        rpm = (float)(a + b + c + d) / 4;
        //animaciones.rotacion(rpm);
    }

    void ApuntarPlayer()
    {
        vector =  playerTransform.position - transform.position;
        angle = Vector3.SignedAngle(transform.forward,vector , Vector3.up);
       
        direccion = Mathf.Clamp(angle * multiplicador * delanteatras, - anguloDireccion , anguloDireccion);
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
}
