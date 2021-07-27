using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorVida : MonoBehaviour
{
    public int vida;
    public int VidaACambiar;

    void Start()
    {
     vida = 100;
    }

    void CambiarVida (int VidaACambiar)
    {
        vida += VidaACambiar;

        if (vida <= 0)
            Destroy(gameObject);
    }
}
