using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaFondo : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip CarreraDeDemolicion;
    [SerializeField] AudioClip SegundaCarreraDemolicion;
    [SerializeField] AudioClip AventuraGrafica;
    [SerializeField] AudioClip Taller;
    [SerializeField] AudioClip Torneo;
    [SerializeField] AudioClip MainMenu;
    [SerializeField] AudioClip Mochila;
    [SerializeField] AudioClip OpcionMenu;

    static string nombreDeEscenaActual;

    void Start()
    {
        nombreDeEscenaActual = SceneManager.GetActiveScene().name;

        switch (nombreDeEscenaActual)
        {
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

            case "MainMenu":
                audioSource.Stop();
                audioSource.clip = MainMenu;
                audioSource.Play();
                break;

            case "Mochila":
                audioSource.Stop();
                audioSource.clip = Mochila;
                audioSource.Play();
                break;

            case "OpcionMenu":
                audioSource.Stop();
                audioSource.clip = OpcionMenu;
                audioSource.Play();
                break;
        }


    }

    void Update()
    {
        
    }
}
