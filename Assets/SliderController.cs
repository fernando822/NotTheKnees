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
    }
}
