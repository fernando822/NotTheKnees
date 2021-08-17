using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
    

    [SerializeField] float actual=0;

    void Update()
    {
        
    }

    private void Start()
    {
   
    }
    public void direccion(float deseada)
    {
        transform.Rotate(Vector3.up, (deseada * 30) - actual);
        actual = deseada * 30;
    }



}

