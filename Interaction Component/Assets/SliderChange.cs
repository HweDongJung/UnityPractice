using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Slider slider;

    // Update is called once per frame
    void Start()
    {
        slider.value = 0.5f;
    }
}
