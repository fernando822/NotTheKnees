using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    Slider sliderTurbo;
    private void Start()
    {
        sliderTurbo = GetComponent<Slider>();
    }
    void Update()
    {
        sliderTurbo.value = Turbo.turboRestante;
        if (Estados.DevolverEstado("gameOver") && this.gameObject.activeSelf)
            sliderTurbo.enabled = false;
        else
            sliderTurbo.enabled = true;
    }
}
