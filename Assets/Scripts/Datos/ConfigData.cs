using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] public class ConfigData 
{
    int resolutionIndex;
    int qualityIndex;
    bool fullScreen;
    public ConfigData(OptionMenu settings){
        resolutionIndex = settings.GetresolutionIndex();
        qualityIndex = settings.GetqualityIndex();
        fullScreen = settings.Getfullscreen();
    }
}

