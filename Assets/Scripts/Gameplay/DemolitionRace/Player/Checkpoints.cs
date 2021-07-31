using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{

    VictoriaDerrota a;

    public void Start()
    {
        a = GameObject.Find("vidas").GetComponent<VictoriaDerrota>();
    }
    public void OnTriggerEnter(Collider collisionInfo)
    {
        a.Checkpoints(collisionInfo.name);


    }




}
