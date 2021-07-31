using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    VictoriaDerrota victoriaDerrota;

    void Start()
    {
        victoriaDerrota = GameObject.Find("RaceManager").GetComponent<VictoriaDerrota>();
    }
    void OnTriggerEnter(Collider collisionInfo)
    {
        victoriaDerrota.Checkpoints(collisionInfo.name);
    }

}
