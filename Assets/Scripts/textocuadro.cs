using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textocuadro : MonoBehaviour
{
    public string content_text = "Esta es la llave para abrir la puerta";
    public Text texto_cuadro;
    public GameObject cuadro;
    
    void Start()
    {
        cuadro.SetActive(false);
        
    }

    
    void Update()
    {
        
    }
    public void ShowText(string texto)
    {
        texto_cuadro.text texto = content_text;
        cuadro.SetActive(true);
        
    }
    public void CerrarText()
    {
        cuadro.SetActive(false);
       
    }
}
