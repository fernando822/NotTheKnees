using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarTexto : MonoBehaviour
{
    public TextMeshProUGUI textoCuadro;

    
    void Start()
    {
        
    }

    public void ShowText(string texto)
    {
        textoCuadro.text = texto;

    }


}
