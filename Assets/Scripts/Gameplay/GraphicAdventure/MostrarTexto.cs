using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarTexto : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoCuadro;
    [SerializeField] GameObject cuadroDeDialogo;
    
    void Start()
    {
        cuadroDeDialogo.SetActive(false);
    }

    public void ShowText(string texto)
    {
        textoCuadro.text = texto;
        cuadroDeDialogo.SetActive(true);
    }

    public void CerrarText()
    {
        cuadroDeDialogo.SetActive(false);
    }
}