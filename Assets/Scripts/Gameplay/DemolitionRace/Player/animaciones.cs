using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    Transform ai, ad, ti, td;

    [SerializeField] float rodamiento = 50;
    [SerializeField] float rotacionDireccion = 30;

    float actual;

    private void Start()
    {

        ai = transform.Find("Rueda ad");
        ad = transform.Find("Rueda ai");
        ti = transform.Find("Rueda td");
        td = transform.Find("Rueda ti");
    }
    public void direccion(float direccion)
    {
        ai.Rotate(Vector3.up, (direccion * rotacionDireccion) - actual, Space.Self);
        ad.Rotate(Vector3.up, (direccion * rotacionDireccion) - actual, Space.Self);
        actual = direccion * rotacionDireccion;


    }
    public void road(float speed)
    {
        float i = speed * rodamiento * Time.deltaTime;

        ai.Rotate(Vector3.forward, i);
        ad.Rotate(Vector3.forward, i);
        ti.Rotate(Vector3.forward, i);
        td.Rotate(Vector3.forward, i);
    }
}

