using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] MostrarTexto mostrarTexto;
    [SerializeField] ObjetoRecogido objetoRecogido;

    private void Start()
    {
        mostrarTexto = GetComponent<MostrarTexto>();
        objetoRecogido = GetComponent<ObjetoRecogido>();
    }

    public void ShowDescriptionOfObtainedObject()
    {
        mostrarTexto.ShowText(ObtenerDescripcion());
    }
    
    string ObtenerDescripcion()
    {
        return objetoRecogido.MostrarDescripcion();
    }


}
