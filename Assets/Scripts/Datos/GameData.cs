using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable] public class GameData
{
    public bool[] estadosBool = new bool[8];
    public GameData(){
        for (int i = 0; i < Estados.CantEstados(); i++)
            this.estadosBool[i] = Estados.DevolverEstado(i); 
    }
}
 