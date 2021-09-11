using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    [SerializeField] float rodamiento = 180;


    [SerializeField] Transform ai;
    [SerializeField] Transform ad;
    [SerializeField] Transform ti;
    [SerializeField] Transform td;

    Rigidbody rb;
    
    float actual;

    float speed ;

    Vector3 speedV3;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       speedV3 = rb.velocity;
       speed = speedV3.magnitude;
        road();
    }
    public void direccion(float direccion)
    {
        ai.Rotate(Vector3.up, (direccion) - actual, Space.World);
        ad.Rotate(Vector3.up, (direccion) - actual, Space.World);
        actual = direccion;
    }
    public void road()
    {
        float i = speed * rodamiento * Time.deltaTime;

       ai.Rotate(Vector3.forward, i);
       ad.Rotate(Vector3.forward, i);
       ti.Rotate(Vector3.forward, i);
       td.Rotate(Vector3.forward, i);
    }
}

