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
        SceneManager.LoadScene(sceneIndex);
    }
    public void CargarEscena(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
