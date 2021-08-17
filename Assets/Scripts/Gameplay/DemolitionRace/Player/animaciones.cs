using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    Transform ai,ad,ti,td;
    float actual;
    float r = 20;
    float rotacionDireccion = 30;
    private void Start()
    {
        ai = transform.Find("Rueda ad");
        ad = transform.Find("Rueda ai");
        ti = transform.Find("Rueda td");
        td = transform.Find("Rueda ti");
    }
    public void direccion(float deseada)
    {
        ai.Rotate(Vector3.up, (deseada * rotacionDireccion) - actual);
        ad.Rotate(Vector3.up, (deseada * rotacionDireccion) - actual);

        actual = deseada * rotacionDireccion;
    }
    public void road(float speed)
    {
        float i = speed * r * Time.deltaTime;

        ai.Rotate(Vector3.forward, i);
        ad.Rotate(Vector3.forward, i);
        ti.Rotate(Vector3.forward, i);
        td.Rotate(Vector3.forward, i);
    }
}

