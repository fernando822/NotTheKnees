using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    [SerializeField] SceneController sceneController;

    private void Start()
    {
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
    }
    public void StartGameButton(){
        sceneController.CargarEscena("AventuraGrafica nueva");
    }
    public void LoadGameButton(){
        sceneController.CargarEscena("LoadGame");
    }
    public void OptionsButton(){
        sceneController.CargarEscena("OptionMenu nuevo");
    }
    public void CreditsButton(){
        sceneController.CargarEscena("CinematicaInicial");
    }
     public void QuitGameButton(){
        Application.Quit();
    }

}

