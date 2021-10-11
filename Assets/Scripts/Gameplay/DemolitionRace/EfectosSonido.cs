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

    private void Start()
    {
        audioSource.clip = motorClip;
        audioSource.Play();
    }
    void Update()
    {
        Motor();
        Debug.Log(motor);
        Debug.Log(choque);
    }

    void Motor()
    {
        motor = Mathf.Sqrt((float)LogicaMovimientoVehiculo.torque/600);
        audioSource.volume = motor;
        
        
    }

    void OnCollisionEnter(Collision other)
    {
        choque = Mathf.Sqrt(other.relativeVelocity.magnitude*5);
        audioSource.PlayOneShot(impact, choque);
    }
}