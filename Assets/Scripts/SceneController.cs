using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void Start()
    {
        
    }
    
    public void CargarEscena(int sceneIndex)
    {
        Scene escena = SceneManager.GetSceneByBuildIndex(sceneIndex);
        SceneManager.SetActiveScene(escena);
    }
    public void CargarEscena(string sceneName)
    {
        Scene escena = SceneManager.GetSceneByName(sceneName);
        SceneManager.SetActiveScene(escena);
    }
    
}
