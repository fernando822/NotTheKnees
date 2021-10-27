using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] TMP_Dropdown resolutionDropDown;
    Resolution[] resolutions;

    void Start(){
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        loadResolutionDropDown();
    }

    void loadResolutionDropDown(){
        resolutionDropDown.ClearOptions();
        resolutionDropDown.AddOptions(getScreenResolutions());
        resolutionDropDown.value = getCurrentResolutionIndex();
        resolutionDropDown.RefreshShownValue();
    }

    List<string> getScreenResolutions(){
        List<string> options = new List<string>();
        for (int i = 0; i < Screen.resolutions.Length; i++)
            options.Add(Screen.resolutions[i].width + " x " + Screen.resolutions[i].height);
        return options;
    }

    int getCurrentResolutionIndex(){
        int resolutionIndex = 0;
        for (int i = 0; i < Screen.resolutions.Length; i++)
            if (isCurrentResolution(i)) resolutionIndex = i;
        return resolutionIndex;
    }

    bool isCurrentResolution(int i){
        if (Screen.resolutions[i].width == Screen.currentResolution.width &&
           Screen.resolutions[i].height == Screen.currentResolution.height)
            return true;
        return false;
    }

    public void SetResolution(int resolutionIndex){
        Screen.SetResolution(
            Screen.resolutions[resolutionIndex].width,
            Screen.resolutions[resolutionIndex].height,
            Screen.fullScreen
            );
    }

    public void SetVolume(float volume) {
        

        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); 
    }

    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool fullscreen){
        Screen.fullScreen = fullscreen;
    }
    public void ExitMenu(){
       SceneManager.UnloadSceneAsync(OptionMenu);
    }
}

