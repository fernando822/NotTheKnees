using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuedaIsGrounded : MonoBehaviour
{
    bool isTouchingGround;

    // Start is called before the first frame update
    void Start()
    {

    } 
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Terrain")
            this.isTouchingGround = true;

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Terrain")
            this.isTouchingGround = false;

    }

    public bool GetIsTouchingGroundStatus() => isTouchingGround;
}
