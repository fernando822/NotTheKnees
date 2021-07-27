using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DecidirObjetoInteractuable
{
    public static GameObject ObjetoMasCercano(List<GameObject> listaDeObjetos, GameObject player)
    {
        
        float distanciaObjetoActual, distanciaObjetoMasCercano;
        distanciaObjetoMasCercano = Vector3.Distance(listaDeObjetos[0].transform.position, 
            player.transform.position);
       
        GameObject objetoAInteractuar = null;
        if (listaDeObjetos.Count > 0)
        {
            foreach (GameObject objeto in listaDeObjetos)
            {
                distanciaObjetoActual = Vector3.Distance(objeto.transform.position,
                    player.transform.position);
                if (distanciaObjetoActual <= distanciaObjetoMasCercano)
                {
                    distanciaObjetoMasCercano = distanciaObjetoActual;
                    objetoAInteractuar = objeto;
                }
            }
            return objetoAInteractuar;
        }

        return null;
    }
}
