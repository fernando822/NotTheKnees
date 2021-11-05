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
        GameManager.GM.CambiarMusica();
        if (!GameManager.nombreDeEscenaActual.Equals("AventuraGrafica") && !GameManager.nombreDeEscenaActual.Contains("Menu"))
            GameManager.GM.PlayerShowControls();
        Estados.ModificarEstado("isUiOpen", false);
        Estados.ModificarEstado("dialogueOngoing", false);
        if(!GameManager.nombreDeEscenaActual.Contains("Menu"))
            Estados.ModificarEstado("inMenu", false);
        else
            Estados.ModificarEstado("inMenu", true);
    }

    public void CargarEscena(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void CargarEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void CargarEscenaAsync(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
    public void CargarEscenaSinRepetir(string sceneName)
    {
        if(SceneManager.GetActiveScene().name != sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            GameManager.GM.ToggleMap();
        }
    }

    public void CerrarEscena(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
    public bool CheckearOpciones()
    {
        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            if (SceneManager.GetSceneAt(i).name.Contains("Option"))
                return true;
        }
        return false;
    }

}
