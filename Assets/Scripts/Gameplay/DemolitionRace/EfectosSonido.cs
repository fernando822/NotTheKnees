using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosSonido : MonoBehaviour
{
    [SerializeField] LogicaMovimientoVehiculo LogicaMovimientoVehiculo;

    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip impact;
    [SerializeField] AudioClip motorClip;

    float motor,choque;

    void Update()
    {
        Motor();
        Debug.Log(motor);
        Debug.Log(choque);
    }

    void Motor()
    {
        motor = Mathf.Sqrt(LogicaMovimientoVehiculo.torque);
        AudioSource.PlayOneShot(motorClip, motor);
    }

    void OnCollisionEnter(Collision other)
    {
        choque = Mathf.Sqrt(other.relativeVelocity.magnitude);
        AudioSource.PlayOneShot(impact, choque);
    }
}
