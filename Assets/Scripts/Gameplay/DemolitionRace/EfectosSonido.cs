using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosSonido : MonoBehaviour
{
    [SerializeField] LogicaMovimientoVehiculo LogicaMovimientoVehiculo;

    [SerializeField] AudioSource audioSourceImpact;
    [SerializeField] AudioSource audioSourceMotor;
    [SerializeField] AudioClip impact;
    [SerializeField] AudioClip motorClip;

    float motor,choque;

    private void Start()
    {
        audioSourceMotor.clip = motorClip;
        audioSourceMotor.Play();
    }
    void Update()
    {
        Motor();
    }

    void Motor()
    {
        motor = Mathf.Sqrt((float)(Mathf.Abs(LogicaMovimientoVehiculo.torque * 0.9f) + LogicaMovimientoVehiculo.aceleration * 0.1f) /
            (LogicaMovimientoVehiculo.aceleration * LogicaMovimientoVehiculo.turboBoost));

       audioSourceMotor.volume = motor;
       audioSourceMotor.pitch = motor;
    }

    void OnCollisionEnter(Collision other)
    {
        choque = Mathf.Sqrt(other.relativeVelocity.magnitude * 5);
        audioSourceImpact.PlayOneShot(impact, choque);
    }
}