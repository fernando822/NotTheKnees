using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;

    public int vida = 100;
    public int attack = 10;

    private void Awake()
    {
        
    }
    void Start()
    {
        contadorVida = GameObject.Find("GameManager").GetComponent<ControladorVida>();
        
    }


    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
            contadorVida.CambiarVida(attack, "Player");

        if (other.gameObject.tag == "Enemy")
            contadorVida.CambiarVida(attack, other.collider.name);


    }

   
}
