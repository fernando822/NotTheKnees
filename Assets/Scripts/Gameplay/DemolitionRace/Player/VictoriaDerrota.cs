using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    public CausarDaño causarDañoP;
    public CausarDaño causarDañoE;

    public Checkpoints meta;
    public Checkpoints checkpoint1;

    public string CheckpointInfo;

    void Start()
    {
        
    }
    public void Vidas()
    {
        if (causarDañoP.vida <= 0)
            Debug.Log("Derrota");

        if (causarDañoE.vida <= 0)
            Debug.Log("Victoria");
    }
   public void Checkpoints(string CheckpointInfo)
    {
        if (CheckpointInfo == "Player")
            Debug.Log("meta");

    }
}
