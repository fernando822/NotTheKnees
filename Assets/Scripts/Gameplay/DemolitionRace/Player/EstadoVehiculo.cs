using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;

    public int vida = 100;
    public int attack = 10;

    void Start()
    {
        contadorVida = GameObject.Find("GameManager").GetComponent<ControladorVida>();
    }


    void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.gameObject.tag == "Player")
        contadorVida.CambiarVida(attack, "Player");

        if(collisionInfo.gameObject.tag == "Enemy")
        contadorVida.CambiarVida(attack, collisionInfo.collider.name);

    }

}
