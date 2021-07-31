using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CausarDaño : MonoBehaviour
{
    ContadorVida contadorVida;

    public int vida = 100;
    public int Attacke= -10;
    int VidaACambiar;

    void Start()
    {
        contadorVida = GameObject.Find("1").GetComponent<ContadorVida>();
    }


    public void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.name=="Player")
        contadorVida.CambiarVida(Attacke, "Player");

        if(collisionInfo.collider.tag == "Enemy")
        contadorVida.CambiarVida(Attacke, collisionInfo.collider.name);

    }

    public void ControlVida(int VidaACambiar)
    {
        vida += VidaACambiar;
    }
}
