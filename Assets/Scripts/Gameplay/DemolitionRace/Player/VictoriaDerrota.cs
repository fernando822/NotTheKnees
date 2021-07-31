using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    CausarDaño causarDañoP;
    CausarDaño causarDañoE;

    Checkpoints meta;

    public string CheckpointInfo;

    void Start()
    {
        causarDañoP = GameObject.Find("Player").GetComponent<CausarDaño>();
        causarDañoE = GameObject.Find("Enemy").GetComponent<CausarDaño>();

        meta = GameObject.Find("Meta").GetComponent<Checkpoints>();
    }

 
    void Update()
    {
        if (causarDañoP.vida <= 0)
            Debug.Log("Derrota");

        if (causarDañoE.vida <= 0)
            Debug.Log("Victoria");
    }
   public void Checkpoints(string CheckpointInfo)
    {
        Debug.Log("meta");
        if (CheckpointInfo == "Player")
            Debug.Log("meta");

    }

}
