using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDialogue : MonoBehaviour
{
    
    void Start()
    {
        if (Estados.DevolverEstado("haveCertificate"))
            this.gameObject.GetComponent<DialogoTrigger>().dialogos.keyWords = new string[] {"Dialogo.Recepcionista005"};

        if(Estados.DevolverEstado("primeraCarreraTerminada"))
            this.gameObject.GetComponent<DialogoTrigger>().dialogos.keyWords = new string[] {"Dialogo.Recepcionista006"};
        
        if (Estados.DevolverEstado("segundaCarreraTerminada"))
            this.gameObject.GetComponent<DialogoTrigger>().dialogos.keyWords = new string[] {"Dialogo.Recepcionista007"};

    }
}
