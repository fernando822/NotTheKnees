using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoNPC : MonoBehaviour
{
    public string tieneLlave()
    {
        return "Buen trabajo";
    }

    public string noTieneLlave()
    {
        return "Mira flaco hace tres meses que estoy encerrado aca, tenes que encontrar la forma de abrir la puerta para participar en la carrera de demolicion que se esta dando afuera wacho";
    }
}