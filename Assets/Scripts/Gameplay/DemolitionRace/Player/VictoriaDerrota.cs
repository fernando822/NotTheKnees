using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    public EstadoVehiculo causarDañoP;
    public EstadoVehiculo causarDañoE;

    public Checkpoints meta;
    public Checkpoints checkpoint1;
    public Checkpoints checkpoint2;

    public GameObject metaOn;
    public GameObject checkpoint1On;
    public GameObject checkpoint2On;

    public string CheckpointInfo;

    void Start()
    {
        metaOn.SetActive(false);
        checkpoint1On.SetActive(true);
        checkpoint2On.SetActive(false);
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
        {
            if(metaOn.active)
            {
                metaOn.SetActive(false);
                checkpoint1On.SetActive(true);
                checkpoint2On.SetActive(false);
                causarDañoP.vueltas++;
                Debug.Log("meta");
            }
            else 
            if(checkpoint1On.active)
            {
                metaOn.SetActive(false);
                checkpoint1On.SetActive(false);
                checkpoint2On.SetActive(true);
                Debug.Log("checkpoint");
            }
            else
            if (checkpoint2On.active)
            {
                metaOn.SetActive(true);
                checkpoint1On.SetActive(false);
                checkpoint2On.SetActive(false);
                Debug.Log("checkpoint2");
            }

        }
    }
}
