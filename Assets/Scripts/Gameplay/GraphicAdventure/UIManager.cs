using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject Llave;
   
    void Start()
    {
        Llave.SetActive(false);
    }

    public void MostrarLlave()
    {
        Llave.SetActive(true);   
    }

    public void OcultarLlave()
    {
        Llave.SetActive(false);
    }
}
