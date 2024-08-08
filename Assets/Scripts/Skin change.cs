using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Skinchange : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _render;
    [SerializeField] private Sprite[] _material;
    [SerializeField] private ChestManager _chest;
    [SerializeField] private TMP_Text[] _text;
    [SerializeField] private TrailRenderer _trail;

    private int _sizeMaterial = -1;

    private void Start()
    {
        SkinText();
        _sizeMaterial = PlayerPrefs.GetInt("Material", _sizeMaterial);
        TakeSkin();
    }

    private void Update()
    {
        TakeSkin();
    }

    private void TakeSkin()
    {
        if (_sizeMaterial == 0)
        {
            _render.color = Color.green;
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
        if (_sizeMaterial == 1)
        {
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.04f, 0.04f);
        }
        if (_sizeMaterial == 2)
        {
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.2f, 0.2f);
        }
        if (_sizeMaterial == 3)
        {
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.07f, 0.07f);
        }
        if (_sizeMaterial == 4)
        {
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.05f, 0.05f);
        }
        if (_sizeMaterial == 5)
        {
            _render.sprite = _material[_sizeMaterial];
            transform.localScale = new Vector2(0.06f, 0.06f);
        }
    }

    public void Sale50()
    {
        if (_text[0].text == "Купить")
        {
            if(_chest._coin >= 150)
            {
                _sizeMaterial = 0;
                _render.sprite = _material[0];
                _chest._coin -= 150;
                _text[0].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("Sale50Pro", _text[0].text);
                PlayerPrefs.Save();
            }
        }

        else
        {
                _text[0].text = "Применино";
                _sizeMaterial = 0;
                _render.sprite = _material[0];
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                Text(1,2,3,4,5);
        }
    }

    public void Bascet()
    {
        if (_text[1].text == "Купить")
        {
            if(_chest._coin >= 300)
            {
                _sizeMaterial = 1;
                _render.sprite = _material[1];
                _chest._coin -= 300;
                _text[1].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("BascketBall", _text[1].text);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _text[1].text = "Применино";
            _sizeMaterial = 1;
            _render.sprite = _material[1];
            PlayerPrefs.SetInt("Material", _sizeMaterial);
            PlayerPrefs.Save();
            Text(0,2,3,4,5);
        }
    }

    public void Bomb()
    {
        if (_text[2].text == "Купить")
        {
            if(_chest._coin >= 300)
            {
                _sizeMaterial = 2;
                _render.sprite = _material[2];
                _chest._coin -= 300;
                _text[2].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("Bomb", _text[2].text);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _text[2].text = "Применино";
            _sizeMaterial = 2;
            _render.sprite = _material[2];
            PlayerPrefs.SetInt("Material", _sizeMaterial);
            PlayerPrefs.Save();
            Text(0,1,3,4,5);
        }
    }

    public void FootBal()
    {
        if (_text[3].text == "Купить")
        {
            if(_chest._coin >= 300)
            {
                _sizeMaterial = 3;
                _render.sprite = _material[3];
                _chest._coin -= 300;
                _text[3].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("FootBall", _text[3].text);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _text[3].text = "Применино";
            _sizeMaterial = 3;
            _render.sprite = _material[3];
            PlayerPrefs.SetInt("Material", _sizeMaterial);
            PlayerPrefs.Save();
            Text(0,1,2,4,5);
        }
    }

    public void GreenBall()
    {
        if (_text[4].text == "Купить")
        {
            if(_chest._coin >= 300)
            {
                _sizeMaterial = 4;
                _render.sprite = _material[4];
                _chest._coin -= 300;
                _text[4].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("GreenBall", _text[4].text);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _text[4].text = "Применино";
            _sizeMaterial = 4;
            _render.sprite = _material[4];
            PlayerPrefs.SetInt("Material", _sizeMaterial);
            PlayerPrefs.Save();
            Text(0,1,2,3,5);
        }
    }

    public void WorldBall()
    {
        if (_text[5].text == "Купить")
        {
            if(_chest._coin >= 300)
            {
                _sizeMaterial = 5;
                _render.sprite = _material[5];
                _chest._coin -= 300;
                _text[5].text = "Применить";
                PlayerPrefs.SetInt("Coin", _chest._coin);
                PlayerPrefs.Save();
                PlayerPrefs.SetInt("Material", _sizeMaterial);
                PlayerPrefs.Save();
                PlayerPrefs.SetString("WorldBall", _text[5].text);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _text[5].text = "Применино";
            _sizeMaterial = 5;
            _render.sprite = _material[5];
            Text(0,1,2,3,4);
            PlayerPrefs.SetInt("Material", _sizeMaterial);
            PlayerPrefs.Save();
        }
    }

    private void SkinText()
    {
        if (PlayerPrefs.HasKey("Sale50Pro"))
        {
            _text[0].text = PlayerPrefs.GetString("Sale50Pro");
        }
        if (PlayerPrefs.HasKey("BascketBall"))
        {
            _text[1].text = PlayerPrefs.GetString("BascketBall");
        }
        if (PlayerPrefs.HasKey("Bomb"))
        {
            _text[2].text = PlayerPrefs.GetString("Bomb");
        }
        if (PlayerPrefs.HasKey("FootBall"))
        {
            _text[3].text = PlayerPrefs.GetString("FootBall");
        }
        if (PlayerPrefs.HasKey("GreenBall"))
        {
            _text[4].text = PlayerPrefs.GetString("GreenBall");
        }
        if (PlayerPrefs.HasKey("WorldBall"))
        {
            _text[5].text = PlayerPrefs.GetString("WorldBall");
        }
    }

    private void Text(int size,int size2,int size3,int size4,int size5)
    {
        if (_text[size].text == "Применить" || _text[size].text == "Применино")
        {
            _text[size].text = "Применить";
        }
        if (_text[size2].text == "Применить" || _text[size2].text == "Применино")
        {
            _text[size2].text = "Применить";
        }
        if (_text[size3].text == "Применить" || _text[size3].text == "Применино")
        {
            _text[size3].text = "Применить";
        }
        if (_text[size4].text == "Применить" || _text[size4].text == "Применино")
        {
            _text[size4].text = "Применить";
        }
        if (_text[size5].text == "Применить" || _text[size5].text == "Применино")
        {
            _text[size5].text = "Применить";
        }
    }
}
