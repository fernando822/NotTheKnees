using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static bool Objrecogido = false;
    public GameObject Llave;
    public Image ImagenLLave;
    void Start()
    {
        Llave.SetActive(false);
        
    }

   public void MostrarLLave()
    {
        if (Objrecogido == true)
        {
            Llave.SetActive(true);
        }
        
    }
    
    void Update()
    {
       
        
    }
}
