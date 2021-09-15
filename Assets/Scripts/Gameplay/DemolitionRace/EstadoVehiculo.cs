using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;

    Rigidbody rb;

    public int vida = 100;
    public int attack = 10;
    public Vector3 speedV3;

    void Start()
    {
        contadorVida = GameObject.Find("GameManager").GetComponent<ControladorVida>();
        rb = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision other)
    {
        speedV3 = rb.velocity;

        if (other.gameObject.tag == "Player")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.tag);


        if (other.gameObject.tag == "Enemy")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.tag);
    }
}
