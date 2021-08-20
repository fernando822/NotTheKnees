using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DescripcionPuerta
{
    public static string DescripcionDeLaPuerta(bool tieneLlave)
    {
        if (!tieneLlave)
        {
            return "Esta cerrada.";
        }
        return "";
    }
    
}
