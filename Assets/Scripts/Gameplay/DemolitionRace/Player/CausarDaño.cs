using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CausarDaño : MonoBehaviour
{
    ControladorVida contadorVida;

    public int vida = 100;
    public int Attacke= -10;
    public int vueltas;

    void Start()
    {
        contadorVida = GameObject.Find("RaceManager").GetComponent<ControladorVida>();
        int vueltas=0;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.name=="Player")
        contadorVida.CambiarVida(Attacke, "Player");

        if(collisionInfo.collider.tag == "Enemy")
        contadorVida.CambiarVida(Attacke, collisionInfo.collider.name);

    }

}
