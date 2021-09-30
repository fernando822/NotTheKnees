using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotate : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
}
