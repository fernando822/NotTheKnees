using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{
    public float velocidad;
    public float angulo;
    public Vector3 direccion;
    public bool PuedeAbrir;

    void Start()
    {
        angulo = transform.eulerAngles.y;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PuedeAbrir = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PuedeAbrir = false;
        }
    }

        void Update()
    {
        //Mathf.Round lo que hace es darte un valor redondo
        if (Mathf.Round(transform.eulerAngles.y) != angulo)
        {
            transform.Rotate(direccion * velocidad);
        }
        if (Input.GetKeyDown(KeyCode.F) && PuedeAbrir == true)
        {
            angulo = 80;
            direccion = Vector3.up;

        }
        else if (Input.GetKeyDown(KeyCode.F) && PuedeAbrir == false)
            angulo = 0;
        direccion = Vector3.down;

    }



}

