using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> lineasDeTexto;
    [SerializeField] TextMeshProUGUI textoCuadro;
    [SerializeField] TextMeshProUGUI textoEmisor;
    string emisor;

    private void Start()
    {
        lineasDeTexto = new Queue<string>();
    }

    public void IniciarDialogo(Dialogos dialogos)
    {
        emisor = dialogos.nombre;
        lineasDeTexto.Clear();

        foreach (string frase in dialogos.frases)
        {
            lineasDeTexto.Enqueue(frase);
        }
        MostrarSiguienteFrase();
        Estados.ModificarEstado("dialogueOngoing", true);
        
    }

    public void MostrarSiguienteFrase()
    {
        if(lineasDeTexto.Count == 0)
        {
            ClearText();
            return;
        }
        string frase = lineasDeTexto.Dequeue();
        ShowText(emisor,frase);
    }
    public void ShowTextProtagonista(string texto)
    {
        SetText(texto);
        DefinirTextoDelEmisor("Protagonista - Amon Gas");
    }
    public void ShowText(string emisor, string texto)
    {
        SetText(texto);
        DefinirTextoDelEmisor(emisor);
    }
    void SetText(string texto)
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
        Estados.ModificarEstado("dialogueOngoing", false);
    }

    public void DefinirTextoDelEmisor(string emisor)
    {
        textoEmisor.text = emisor;
    }
}
