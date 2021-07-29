using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescObjInteractuable : MonoBehaviour
{
    DescripcionInteractuable descripcion;

    void Start() {
        descripcion = GameObject.Find("Player").GetComponent<DescripcionInteractuable>(); 
    }
   
    public string MostrarDescripcionInteractuable()
    {
        return descripcion.GetDescripcion();
    
    }








}


