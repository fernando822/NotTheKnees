using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void OnLevelWasLoaded()
    {
        GameManager.GM.ActualizarReferencias();
        Estados.ModificarEstado("isUiOpen", false);
        Estados.ModificarEstado("dialogueOngoing", false);
    }

    public void CargarEscena(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void CargarEscena(string sceneName)
    {
        CheckearMenu(sceneName);
        SceneManager.LoadScene(sceneName);
    }
    public void CargarEscenaSinRepetir(string sceneName)
    {
        if(SceneManager.GetActiveScene().name != sceneName)
        {
            CheckearMenu(sceneName);
            SceneManager.LoadScene(sceneName);
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
