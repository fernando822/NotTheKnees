using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoRecogido : MonoBehaviour
{
    [SerializeField] GameManagerAventura gameManager;

    public string Nombre = "Llave";
    private string Descripcion = "Esta parece ser la llave de la puerta.";

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerAventura>();
    }

    public string MostrarDescripcion()
    {
        return Descripcion;
    }
}
