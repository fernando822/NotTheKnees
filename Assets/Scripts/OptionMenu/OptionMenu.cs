using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization.Settings;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] SceneController sceneController;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] TMP_Dropdown resolutionDropDown;
    [SerializeField] TMP_Dropdown qualityDropDown;
    Resolution[] resolutions;

    void Start(){
        sceneController = GameObject.Find("SceneManager").GetComponent<SceneController>();
        loadResolutionDropDown();
        LocalizationSettings.SelectedLocaleChanged += LocalizationSettings_SelectedLocaleChanged; ;
    }

    private void LocalizationSettings_SelectedLocaleChanged(UnityEngine.Localization.Locale obj)
    {
        LoadqualityDropDown();
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

   void LoadqualityDropDown()
    {
        qualityDropDown.ClearOptions();
        qualityDropDown.AddOptions(GetScreenQualities());
        qualityDropDown.value = 5;
        qualityDropDown.RefreshShownValue();
    }
    List<string> GetScreenQualities(){
        List<string> options = new List<string>();
        if (LocalizationSettings.SelectedLocale.name == "en"){
            options.Add("Very Low");
            options.Add("Low");
            options.Add("Medium");
            options.Add("High");
            options.Add("Very High");
            options.Add("Ultra");
        }
        else
        {
            options.Add("Muy bajaaaaaa");
            options.Add("Baja");
            options.Add("Media");
            options.Add("Alta");
            options.Add("Muy alta");
            options.Add("Ultra");
        }
        return options;
    }
    public void SetQuality(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool fullscreen){
        Screen.fullScreen = fullscreen;
    }
    public void ExitMenu(){
       SceneManager.UnloadSceneAsync("OptionMenu");
    }   
    public int GetqualityIndex()
    {
        return this.qualityDropDown.value;
    }
    public int GetresolutionIndex()
    {
        return this.resolutionDropDown.value;
    }
    public bool Getfullscreen()
    {
        return Screen.fullScreen;
    }

}

