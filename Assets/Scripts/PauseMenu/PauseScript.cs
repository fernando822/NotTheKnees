using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    private bool pause = false;
    public GameObject PausePanel;
    [SerializeField] AdventureGraphicMovement adventurePlayer;
    [SerializeField] LogicaMovimientoVehiculo racePlayer;
    [SerializeField]  SceneController sceneController; 
    void Start()
    {
        adventurePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<AdventureGraphicMovement>();
        racePlayer = GameObject.Find("PlayerDemolitionRace").GetComponent<LogicaMovimientoVehiculo>();
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pause = !pause;
        }
        if(pause){
            Time.timeScale = 0;
            adventurePlayer.enabled = false;
            racePlayer.enabled = false;
            PausePanel.SetActive(true);
        }
        else if(!pause){
            Time.timeScale = 1;
            adventurePlayer.enabled = true;
            racePlayer.enabled = true;
            PausePanel.SetActive(false);

        }

       }
       public void botonopciones(){
           sceneController.CargarEscena("OptionMenu");
       }
       public void salir(){
           Application.Quit();
       }
}
