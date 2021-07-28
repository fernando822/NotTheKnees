using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CausarDaño : MonoBehaviour
{
    public int VidaACambiar = 3;

    

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player");
        {
            ContadorVida.CambiarVida(VidaACambiar = 3);
            (collisionInfo.gameObject).ContadorVida.CambiarVida(VidaACambiar = 3);

        }
    }

   
}
