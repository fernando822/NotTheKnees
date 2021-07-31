using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuedeUtilizarObjetoRecogido : MonoBehaviour
{
    public static bool PuedeUsar = false;
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider other)
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
    public  bool PuedeUtilizarObjeto()
    {
        return PuedeUsar;
    }
}
