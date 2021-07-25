using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarTexto : MonoBehaviour
{
    public TextMeshProUGUI texto_cuadro;
    public GameObject cuadro;
    
    void Start()
    {
        cuadro.SetActive(false);
        
    }

    public void ShowText(string texto)
    {
        texto_cuadro.text = texto;
        cuadro.SetActive(true);
    }

    public void CerrarText()
    {
        cuadro.SetActive(false);
    }
}
