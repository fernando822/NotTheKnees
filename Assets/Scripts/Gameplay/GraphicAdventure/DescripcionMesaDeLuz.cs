using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DescripcionMesaDeLuz
{

    public static string DescripcionDeLaMesaDeLuz(bool tieneLlave)
    {
        if (tieneLlave)
        {
            return TieneLlave();
        }
        else
        {
            return NoTieneLlave();
        }
    }
    public static string TieneLlave()
    {
        return "No hay ninguna otra cosa de utilidad.";
    }

    public static string NoTieneLlave()
    {
        if (!GameManagerAventura.interactuoConNPC)
        {
            return "La unica que me hace compañia por las noches.";
        }
        else
        {
            return "Hay una llave dentro de la mesa de luz, puede ser la de la puerta, asi que me la llevo.";
        }
    }
}
