using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void StartGameButton(){
        GameManager.GM.CurrentScene = "Aventura Grafica";
        SceneManager.LoadScene("AventuraGrafica", LoadSceneMode.Single);
        
    }
    public void OptionsButton(){
        SceneManager.LoadScene("OptionMenu", LoadSceneMode.Additive);
      
    }
    public void CreditsButton(){
        SceneManager.LoadScene("Creditos", LoadSceneMode.Additive);
    }
     public void QuitGameButton(){
        Application.Quit();
    }

}

