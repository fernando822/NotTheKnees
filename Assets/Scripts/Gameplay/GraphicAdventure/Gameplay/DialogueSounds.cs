using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip audioClip;

    public void Sound()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }

}
