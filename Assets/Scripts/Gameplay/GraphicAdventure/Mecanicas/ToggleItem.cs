using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleItem : MonoBehaviour
{
    
    void Update()
    {
        if (Estados.DevolverEstado("haveToolBox"))
        {
            this.gameObject.transform.position = new Vector3(1000,1000,1000);
        }
        
    }


}
