using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuedeInteractuar : MonoBehaviour
{
    public static bool interactuable = false;
    float distanciaObjetoActual;
    float distanciaObjetoMasCercano;
    List<GameObject> gameObjects = new List<GameObject>();

    public List<GameObject> GetGameObjects()
    {
        return gameObjects;
    }
  

    void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;
        if (tag == "ObjetoInteractuable" ||
            tag == "ObjetoInteractuableEscenario" ||
            tag == "NPC")
        {
            interactuable = true;
            gameObjects.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        string tag = other.gameObject.tag;
        if (tag == "ObjetoInteractuable" || 
            tag == "ObjetoInteractuableEscenario" ||
            tag == "NPC")
        { 
            gameObjects.Remove(other.gameObject);
            if(gameObjects.Count == 0)
            {
                interactuable = false;
            }

        }

    }


    
}