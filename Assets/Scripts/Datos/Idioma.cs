using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class Idioma : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(SetLanguage());
    }
    public IEnumerator SetLanguage()
    {
        yield return LocalizationSettings.InitializationOperation;

        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
    }

    
}
