using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescObjInteractuable : MonoBehaviour
{
   public string Descripcion;

    [SerializeField] GameManager gameManager;
    

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

  
    
        





}


