using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    CausarDaño causarDañoP;
    CausarDaño causarDañoE;

    void Start()
    {
        causarDañoP = GameObject.Find("Player").GetComponent<CausarDaño>();
        causarDañoE = GameObject.Find("Enemy").GetComponent<CausarDaño>();
    }

 
    void Update()
    {
        if (causarDañoP.vida <= 0)
            Debug.Log("Derrota");

        if (causarDañoE.vida <= 0)
            Debug.Log("Victoria");
    }
}
