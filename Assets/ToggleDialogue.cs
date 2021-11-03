using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDialogue : MonoBehaviour
{
    
    void Start()
    {
        if (Estados.DevolverEstado("haveCertificate"))
            this.gameObject.GetComponent<DialogoTrigger>().dialogos.keyWords = new string[] {"Dialogo.Recepcionista005"};
    }
}
