using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecogido : MonoBehaviour
{
    public string Nombre = "Llave";
    private string Descripcion = "Esta parece ser la llave de la puerta.";

    
    public string MostrarDescripcion()
    {
        return Descripcion;
    }
}
