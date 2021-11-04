using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> lineasDeTexto;
    [SerializeField] TextMeshProUGUI textoCuadro;
    [SerializeField] TextMeshProUGUI textoEmisor;
    [SerializeField] LocalizedStringTable traducciones;
    [SerializeField] LocalizedStringTable traduccionesUI;
    string emisor;

    //[SerializeField] DialogueSounds dialogueSounds;

    private void Start()
    {
        lineasDeTexto = new Queue<string>();
    }
    
    public void IniciarDialogo(Dialogos dialogos)
    {
        emisor = dialogos.nombre;
        lineasDeTexto.Clear();
        foreach (string frase in dialogos.keyWords)
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
        string keyWord = lineasDeTexto.Dequeue();
        ShowText(emisor, traducciones.GetTable()[keyWord].Value);
    }
    public void ShowTextUI(string keyWord)
    {
        ShowText("Amon Gas", traduccionesUI.GetTable()[keyWord].Value);
    }
    public void ShowText(string emisor, string texto)
    {
        SetText(texto);
        DefinirTextoDelEmisor(emisor);
        //Sounds();
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
    public void EndDialogue()
    {
        lineasDeTexto.Clear();
        ClearText();
    }
    public void DefinirTextoDelEmisor(string emisor)
    {
        textoEmisor.text = emisor;
    }

    public void Controlador(string nombreObjeto)
    {
        switch (nombreObjeto)
        {
            case "Tio":
                Estados.ModificarEstado("haveKey", true);
                GameManager.GM.ActualizarMochila();
                break;
            case "Recepcion":
                Estados.ModificarEstado("haveCertificate", true);
                GameManager.GM.ActualizarMochila();
                break;
            case "PuertaCasa":
                if (Estados.DevolverEstado("haveKey"))
                {
                    GameManager.GM.LimpiarTexto();
                    GameManager.GM.ToggleMap();
                    break;
                }
                break;
            case "PuertaEmpezarCarrera":
                if (Estados.DevolverEstado("haveCertificate"))
                {
                    GameManager.GM.LimpiarTexto();
                    if (!Estados.DevolverEstado("primeraCarreraTerminada"))
                    {
                        GameManager.GM.CargarEscena("CarreraDeDemolicion");
                        break;
                    }
                    if (!Estados.DevolverEstado("segundaCarreraTerminada"))
                    {
                        GameManager.GM.CargarEscena("SegundaCarreraDemolicion");
                        break;
                    }
                    else
                    {
                        GameManager.GM.CargarEscena("TerceraCarreraDemolicion");
                        break;
                    }
                }
                break;
            case "PuertaEntradaTorneo":
                GameManager.GM.LimpiarTexto();
                GameManager.GM.ToggleMap();
                break;
            case "PuertaTaller":
                if (Estados.DevolverEstado("checkedCar"))
                {
                    GameManager.GM.LimpiarTexto();
                    GameManager.GM.ToggleMap();
                }
                break;
            case "CajaHerramientas":
                Estados.ModificarEstado("haveToolBox", true);
                break;
            case "Elevador":
                Estados.ModificarEstado("checkedCar", true);
                break;
            case "Enemigo1(Clone)":
                Sabotear();
                break;
            case "Enemigo2(Clone)":
                Sabotear();
                break;
            case "Enemigo3(Clone)":
                Sabotear();
                break;
            default:

                break;
        }

        
    }

    public void Sabotear()
    {
        if (Estados.DevolverEstado("haveToolBox"))
        {
            if (!Estados.DevolverEstado("dialogueOngoing"))
            {
                if(!Estados.DevolverEstado("vehiculoSaboteado"))
                    GameManager.GM.ToggleChoices();
            }
        }
    }
    /*public void Sounds()
    {
        dialogueSounds.Sound();
    }*/
}
