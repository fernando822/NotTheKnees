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
        return "Buen trabajo";
    }

    public static string NoTieneLlave()
    {
        return "Mira flaco hace tres meses que estoy encerrado aca," +
    " tenes que encontrar la forma de abrir la puerta" +
    " para participar en la carrera de demolicion que se esta dando afuera wacho";
    }
}