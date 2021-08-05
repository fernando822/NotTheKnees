using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogoNPC
{
    public static string DialogoDelNPC(bool tieneLlave)
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
        return "Creo que esa llave es de la puerta, muchas gracias.";
    }

    public static string NoTieneLlave()
    {
        if (!GameManagerAventura.interactuoConNPC)
        {
            return "Mira flaco hace tres meses que estoy encerrado aca," +
            " tenes que encontrar la forma de abrir la puerta" +
            " para participar en la carrera de demolicion que se esta dando afuera wacho";
        }
        else
        {
            return "Te dije que encuentres la forma de abrir la puerta, apurate por favor!";
        }
    }
}