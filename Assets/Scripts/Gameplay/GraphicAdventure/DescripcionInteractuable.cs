using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescripcionInteractuable : MonoBehaviour
{
    [SerializeField] string descripcion;
    
    public string GetDescripcion()
    {
        return descripcion;
    }
}
