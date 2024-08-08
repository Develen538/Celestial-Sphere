using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _chest;
    [SerializeField] private GameObject _magazin;
    [SerializeField] private GameObject _settings;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Play()
    {
        _menu.SetActive(false);
        Time.timeScale = 1;
        
    }

    public void Chest()
    {
        _menu.SetActive(false);
        _chest.SetActive(true);
        Time.timeScale = 0;
    }

    public void Magazin()
    {
        _menu.SetActive(false);
        _magazin.SetActive(true);
        Time.timeScale = 0;
    }

    public void Settings()
    {
        _menu.SetActive(false);
        _settings.SetActive(true);
        Time.timeScale = 0;
    }

    public void Exit()
    {
        _menu.SetActive(true);
        _chest.SetActive(false);
        _magazin.SetActive(false);
        _settings.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
