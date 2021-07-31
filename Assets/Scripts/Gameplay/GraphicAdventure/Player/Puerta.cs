using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    PuedeUtilizarObjetoRecogido recogido;

    public bool puedeAbrir = false;
    void Start()
    {
        recogido = GameObject.Find("PuedeUtilizarObjetoRecogido").GetComponent<PuedeUtilizarObjetoRecogido>();
    }

   
    void Update()
    {
       
    }

    public void AbrirPuerta()
    {
        recogido.GetComponent(PuedeUtilizarObjeto());
    }
}
