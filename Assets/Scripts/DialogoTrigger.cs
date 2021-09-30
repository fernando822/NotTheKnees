using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    [SerializeField] DialogueManager dialogueManager;
    public Dialogos dialogos;

    private void Start()
    {
        dialogueManager = GetComponent<DialogueManager>();
    }

    public void IniciarDialogoNPC()
    {
        dialogueManager.IniciarDialogo(this.dialogos);
    }


}
