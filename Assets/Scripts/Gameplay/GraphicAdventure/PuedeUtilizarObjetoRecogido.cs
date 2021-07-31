using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuedeUtilizarObjetoRecogido : MonoBehaviour
{
    public static bool PuedeUsar = false;
   
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ObjetoInteractuableEscenario")
        {
            PuedeUsar = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ObjetoInteractuableEscenario")
        {
            PuedeUsar = false;
        }
    }
    }
    
