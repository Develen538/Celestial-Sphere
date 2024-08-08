using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Plane : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] private ParticleSystem _boom;

    private AudioSource _audio;

    private void Start()
    {
        if (PlayerPrefs.HasKey("volume2"))
        {
            slider.value = PlayerPrefs.GetFloat("volume2");
        }
        _audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (slider.value != _audio.volume)
        {
            PlayerPrefs.SetFloat("volume2", slider.value);
            _audio.volume = slider.value;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle component))
        {
        _boom.Play();
            _audio.Play();
        }
    }
}
