using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] AdventureGraphicMovement adventurePlayer;
    [SerializeField] LogicaMovimientoVehiculo racePlayer;
    [SerializeField] SceneController sceneController;
    [SerializeField] GameObject pausePanel;

    void Start()
    {
        pausePanel = GameObject.Find("PausePanel");
        pausePanel.SetActive(false);
        if (GameManager.nombreDeEscenaActual.Contains("Carrera"))
            racePlayer = GameObject.Find("PlayerDemolitionRace").GetComponent<LogicaMovimientoVehiculo>();
        else
            adventurePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<AdventureGraphicMovement>();
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
    }

    
    void Update()
    {
        
        if (!sceneController.CheckearOpciones())
        {
            if (Estados.DevolverEstado("isPaused"))
            {
                Time.timeScale = 0;
                if (adventurePlayer != null)
                    adventurePlayer.enabled = false;
                if (racePlayer != null)
                    racePlayer.enabled = false;
                pausePanel.SetActive(true);
            }
            else if (!Estados.DevolverEstado("isPaused"))
            {
                Time.timeScale = 1;
                if (adventurePlayer != null)
                    adventurePlayer.enabled = true;
                if (racePlayer != null)
                    racePlayer.enabled = true;
                pausePanel.SetActive(false);
            }
        }
        
    }

    public void BotonOpciones(){
        sceneController.CargarEscenaAsync("OptionMenu");
    }
    public void Salir(){
        Application.Quit();
    }
}
