using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetointeractuable : MonoBehaviour
{
    public static bool interactuable = false;
    

    void Start()
    {

       

    }
    
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ObjetoInteractuable" || other.gameObject.tag == "ObjetoInteractuableEscenario")
        {
            interactuable = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ObjetoInteractuable" || other.gameObject.tag == "ObjetoInteractuableEscenario")
        {
            interactuable = false;
        }
    }
}