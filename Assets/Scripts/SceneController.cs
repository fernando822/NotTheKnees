using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void OnLevelWasLoaded()
    {
        GameManager.nombreDeEscenaActual = SceneManager.GetActiveScene().name;
        GameManager.GM.ActualizarReferencias();
        if (!GameManager.nombreDeEscenaActual.Equals("AventuraGrafica") && !GameManager.nombreDeEscenaActual.Contains("Menu"))
            GameManager.GM.PlayerShowControls();
        Estados.ModificarEstado("isUiOpen", false);
        Estados.ModificarEstado("dialogueOngoing", false);
        if(!GameManager.nombreDeEscenaActual.Contains("Menu"))
            Estados.ModificarEstado("inMenu", false);
        CheckearMenu(GameManager.nombreDeEscenaActual);
    }

    public void CargarEscena(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void CargarEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void CargarEscenaSinRepetir(string sceneName)
    {
        if(SceneManager.GetActiveScene().name != sceneName)
        {
            CheckearMenu(sceneName);
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            GameManager.GM.ToggleMap();
        }
    }

    void CheckearMenu(string sceneName)
    {
        if (sceneName != "MainMenu" && sceneName != "OptionMenu")
            Estados.ModificarEstado("inMenu", false);
        else
            Estados.ModificarEstado("inMenu", true);
    }

}
