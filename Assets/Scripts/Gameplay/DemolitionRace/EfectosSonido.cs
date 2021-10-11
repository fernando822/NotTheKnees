using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectosSonido : MonoBehaviour
{
    [SerializeField] LogicaMovimientoVehiculo LogicaMovimientoVehiculo;

    [SerializeField] AudioSource audioSource;
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
        audioSource.clip = motorClip;
        audioSource.Play();
        audioSource.volume = motor;
    }

    void OnCollisionEnter(Collision other)
    {
        choque = Mathf.Sqrt(other.relativeVelocity.magnitude);
        audioSource.PlayOneShot(impact, choque);
    }
}
