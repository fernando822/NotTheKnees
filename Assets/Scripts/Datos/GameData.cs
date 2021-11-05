using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable] public class GameData
{
    public bool[] estadosBool = new bool[Estados.CantEstados()-1];
    public string nombreDeEscenaActual;
    public int indexLocale;
    public int karma;
    public GameData(){
        for (int i = 0; i < Estados.CantEstados(); i++)
            this.estadosBool[i] = Estados.DevolverEstado(i);
        nombreDeEscenaActual = GameManager.nombreDeEscenaActual;
        indexLocale = GameManager.indexLocale;
        karma = GameManager.karma;
    }
}
 