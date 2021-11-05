using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminarCinematica : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("AventuraGrafica", LoadSceneMode.Single);
    }
}
