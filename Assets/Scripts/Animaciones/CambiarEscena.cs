using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void CargarEscena(string sceneName)
    {
        bool menuExist = false;
        for(int i = 0; i < SceneManager.sceneCount; i++)
        {
            if (SceneManager.GetSceneAt(i).name.Equals(sceneName))
                menuExist = true;
        }
        if (!menuExist)
            SceneManager.LoadScene("MainMenu");
        SceneManager.UnloadSceneAsync("CinematicaInicial");

    }
}
