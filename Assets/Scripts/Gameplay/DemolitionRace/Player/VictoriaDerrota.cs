using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    public EstadoVehiculo EstadoVehiculoP;
    public EstadoVehiculo EstadoVehiculoE;

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
        if (EstadoVehiculoP.vida <= 0)
            Debug.Log("Derrota");

        if (EstadoVehiculoE.vida <= 0)
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
                EstadoVehiculoP.vueltas++;
                Debug.Log("meta");
            }
            else 
            if(checkpoint1On.active)
            {
                checkpoint1On.SetActive(false);
                checkpoint2On.SetActive(true);
                Debug.Log("checkpoint");
            }
            else
            if (checkpoint2On.active)
            {
                checkpoint2On.SetActive(false);
                metaOn.SetActive(true);
                Debug.Log("checkpoint2");
            }

        }
    }
}
