using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Estados
{
    public static Dictionary<string, bool> estados;


    public static void AgregarEstado(string nombre, bool status)
    {
        estados.Add(nombre,status);
    }

    public static bool DevolverEstado(string nombre)
    {
        bool estado = estados[nombre];
        return estado;
    }

    public static void ModificarEstado(string nombre, bool status)
    {
        estados[nombre] = status;
    }
}
