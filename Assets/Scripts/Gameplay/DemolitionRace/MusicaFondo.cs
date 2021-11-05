using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField] AudioClip CarreraDeDemolicion;
    [SerializeField] AudioClip SegundaCarreraDemolicion;
    [SerializeField] AudioClip TerceraCarreraDemolicion;
    [SerializeField] AudioClip AventuraGrafica;
    [SerializeField] AudioClip Taller;
    [SerializeField] AudioClip Torneo;
    [SerializeField] AudioClip MainMenu;


    public void CambiarMusica(string sceneName)
    {
        audioSource = GetComponent<AudioSource>();
        switch (sceneName)
        {
            case "MainMenu":
                audioSource.Stop();
                audioSource.Play();
                audioSource.clip = MainMenu;
                audioSource.Play();
                break;

            case "CarreraDeDemolicion":
                audioSource.Stop();
                audioSource.clip = CarreraDeDemolicion;
                audioSource.Play();
                break;

            case "SegundaCarreraDemolicion":
                audioSource.Stop();
                audioSource.clip = SegundaCarreraDemolicion;
                audioSource.Play();
                break;

            case "TerceraCarreraDemolicion":
                audioSource.Stop();
                audioSource.clip = TerceraCarreraDemolicion;
                audioSource.Play();
                break;

            case "AventuraGrafica":
                audioSource.Stop();
                audioSource.clip = AventuraGrafica;
                audioSource.Play();
                break;

            case "Taller":
                audioSource.Stop();
                audioSource.clip = Taller;
                audioSource.Play();
                break;

            case "Torneo":
                audioSource.Stop();
                audioSource.clip = Torneo;
                audioSource.Play();
                break;

            default:
                audioSource.Stop();
                audioSource.clip = null;
                break;
        }


    }

}
