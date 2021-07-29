using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CausarDaño : MonoBehaviour
{
    ContadorVida y;


    void Start()
    {
        y = GameObject.Find("Player").GetComponent<ContadorVida>();

    }


    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {


            y.CambiarVida(-10);


        }
    }
}
