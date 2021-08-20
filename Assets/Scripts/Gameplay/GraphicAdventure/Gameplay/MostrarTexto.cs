using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostrarTexto : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoCuadro;
    [SerializeField] TextMeshProUGUI textoEmisor;



    void Update()
    {
       
    }
    public void ShowTextProtagonista(string texto)
    {
        textoCuadro.enableAutoSizing = true;
        if (CompararTexto(texto))
        {
            ClearText();
        }
        else
        {
            textoCuadro.text = texto;
        }
        if (textoCuadro.isTextOverflowing) RefreshFontSize();

        DefinirTextoDelEmisor("Protagonista - Amon Gas");
    }
    public void ShowText(string emisor, string texto)
    {
        textoCuadro.enableAutoSizing = true;
        if (CompararTexto(texto)) {
            ClearText();
        }
        else
        {
            textoCuadro.text = texto;
        }
        if (textoCuadro.isTextOverflowing) RefreshFontSize();

        DefinirTextoDelEmisor(emisor);
    }

    public bool CompararTexto(string textoAnterior)
    {
        if(textoCuadro.text == textoAnterior)
        {
            return true;
        }
            return false;
    }
    public void RefreshFontSize()
    {
        textoCuadro.enableAutoSizing = false;
        textoCuadro.fontSizeMin = 32;
        textoCuadro.fontSizeMax= 120;
        textoCuadro.enableAutoSizing = true;

    }
    public void ClearText()
    {
        textoCuadro.text = "";
        textoEmisor.text = "";
    }

    public void DefinirTextoDelEmisor(string emisor)
    {
        textoEmisor.text = emisor;
    }
}
