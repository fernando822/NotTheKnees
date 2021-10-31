using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Estados
{
    public static Dictionary<string, bool> estados;


    public static void AgregarEstado(string nombre, bool status)
    {
        estados.Add(nombre, status);
    }

    public static bool DevolverEstado(string nombre)
    {
        if (estados.ContainsKey(nombre) && estados[nombre])
            return true;
        return false;
    }

    public static void ModificarEstado(string nombre, bool status)
    {
        if (estados.ContainsKey(nombre))
            estados[nombre] = status;
    }
    public static int CantEstados(){
        return estados.Count;

    }
    public static bool DevolverEstado(int indice){
        return estados.Values.ElementAt(indice);

    }
}
