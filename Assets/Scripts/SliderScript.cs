using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    public TextMeshProUGUI numberText;

    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.value);
    }

    public void SetNumberText(float value)
    {
        //float visualValue = value * 100;
        //numberText.text = visualValue.ToString();
        numberText.text = value.ToString();
    }

}
