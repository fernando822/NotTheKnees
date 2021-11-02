using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour
{
    [SerializeField] LogicaMovimientoVehiculo logicaMovimientoVehiculo;
    public static float turboRestante;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        Aplicate();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Turbo")
        {
            turboRestante = 20;
            Destroy(other.gameObject);
            SpawnTurbo.contadorTurbos--;
        }
    }

   void Aplicate()
   {
        if (turboRestante > 0)
        {
            turboRestante -= Time.deltaTime;
            logicaMovimientoVehiculo.Turbo = true;
        }
        else
            logicaMovimientoVehiculo.Turbo = false;
    }
}
