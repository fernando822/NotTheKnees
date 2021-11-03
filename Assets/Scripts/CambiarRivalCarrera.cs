using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarRivalCarrera : MonoBehaviour
{
    [SerializeField] GameObject oponente1;
    [SerializeField] GameObject oponente2;
    [SerializeField] GameObject oponente3;
    [SerializeField] GameObject oponenteVehiculo1;
    [SerializeField] GameObject oponenteVehiculo2;
    [SerializeField] GameObject oponenteVehiculo3;
    [SerializeField] GameObject oponenteSpawn;
    [SerializeField] GameObject oponenteVehiculoSpawn;
    void Start()
    {
        if(!Estados.DevolverEstado("primeraCarreraTerminada"))
        {
            Instantiate(oponente1, oponenteSpawn.transform.position, Quaternion.identity);
            Instantiate(oponenteVehiculo1, oponenteVehiculoSpawn.transform.position, Quaternion.identity);
        }
        else
        {
            if (!Estados.DevolverEstado("segundaCarreraTerminada"))
            {
                Instantiate(oponente2, oponenteSpawn.transform.position, Quaternion.identity);
                Instantiate(oponenteVehiculo2, oponenteVehiculoSpawn.transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(oponente3, oponenteSpawn.transform.position, Quaternion.identity);
                Instantiate(oponenteVehiculo3, oponenteVehiculoSpawn.transform.position, Quaternion.identity);
            }
        }
    }

}
