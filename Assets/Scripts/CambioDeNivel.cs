using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeNivel : MonoBehaviour
{
    public SceneController sceneManager;
    
    public void CambiarNivel(string SceneName)
    {
        sceneManager.CargarEscena(SceneName);
    }
    public void CambiarNivel(int SceneIndex)
    {
        sceneManager.CargarEscena(SceneIndex);
    }
}