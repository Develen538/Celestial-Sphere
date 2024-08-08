using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSound : MonoBehaviour
{
    [SerializeField] Slider slider;

    private AudioSource _audio;

    private void Start()
    {
            slider.value = PlayerPrefs.GetFloat("volume");
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (slider.value != _audio.volume)
        {
            PlayerPrefs.SetFloat("volume", slider.value);
            _audio.volume = slider.value;
        }
    }
}
