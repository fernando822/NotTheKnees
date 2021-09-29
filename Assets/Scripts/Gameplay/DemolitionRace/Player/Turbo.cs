using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour
{
    [SerializeField] LogicaMovimientoVehiculo logicaMovimientoVehiculo;
    public float turboRestante;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        p();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Turbo")
            turboRestante += 20;
    }

   void p()
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
