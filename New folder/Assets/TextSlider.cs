using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextSlider : MonoBehaviour
{
    public TextMeshProUGUI numberText;

    private Slider slider;

    private void Start() 
    {
        slider = GetComponent<Slider>();
        SetNumberText(slider.value);
        slider.onValueChanged.AddListener(SetVolume);
    }

    public void SetNumberText(float value)
    {
        numberText.text = value.ToString();
    }

    public AudioSource backgroundMusic;

    public void SetVolume(float volume)
    {
        backgroundMusic.volume = volume;
    }
}
