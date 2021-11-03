using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarEscena : MonoBehaviour
{
    public void CargarEscena(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
