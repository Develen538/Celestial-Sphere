using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class ChestManager : MonoBehaviour
{
    [SerializeField] public TMP_Text[] _coinText;
    [SerializeField] private TMP_Text _keyText;
    [SerializeField] private TMP_Text _goldKeyText;
    [SerializeField] private TMP_Text _sizeEffect;
    [SerializeField] private GameObject _winning;
    [SerializeField] private Sprite[] _item;
    [SerializeField] private Image _coinItem;

    public int _coin;
    public int _goldKey;
    public int _key;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Coin"))
        {
            _coin = PlayerPrefs.GetInt("Coin");
        }
        if (PlayerPrefs.HasKey("Key"))
        {
            _key = PlayerPrefs.GetInt("Key");
        }
        if (PlayerPrefs.HasKey("GoldKey"))
        {
            _goldKey = PlayerPrefs.GetInt("GoldKey");
        }
    }

    private void Update()
    {
        for (int i = 0; i < _coinText.Length; i++)
        {
            _coinText[i].text = "" + _coin;
        }
        _keyText.text = "" + _key;
        _goldKeyText.text = "" + _goldKey;
    }


    private void addMoney(string name, int size, TMP_Text text)
    {
        text.text = "" + size;
        PlayerPrefs.SetInt(name, size);
        PlayerPrefs.Save();
    }

    private void Count(string name, int size, TMP_Text text)
    {
        addMoney(name, size, text);
        PlayerPrefs.SetInt(name, size);
        PlayerPrefs.Save();
    }

    private void Prefs(string name, int size)
    {
        PlayerPrefs.SetInt(name, size);
        PlayerPrefs.Save();
    }

    private void WinningSize(int item, float vector)
    {
        _coinItem.sprite = _item[item];
        _coinItem.transform.localScale = new Vector2(vector, 1);
        _winning.SetActive(true);
        Time.timeScale = 0;
    }

    public void DefultChest2()
    {
        if (_coin >= 1)
        {
            _coin -= 1;
            Prefs("Coin", _coin);
            if (Random.Range(1, 5) == 3)
            {
                _key++;
                Count("Key", _key, _keyText);
                WinningSize(1,1.5f);
                _sizeEffect.text = "1";
            }
            else if (Random.Range(1, 50) == 15)
            {
                _key += 3;
                Count("Key", _key, _keyText);
                WinningSize(1, 1.5f);
                _sizeEffect.text = "3";
            }
        }
    }

    public void DefultChest1()
    {
        if (_key >= 1)
        {
            _key -= 1;
            Prefs("Key", _key);
            if (Random.Range(1, 5) == 3)
            {
                _key += 2;
                Count("Key", _key, _keyText);
                WinningSize(1, 1.5f);
                _sizeEffect.text = "2";
            }
            else if (Random.Range(1, 50) == 15)
            {
                _goldKey++;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "1";
            }
        }
    }

    public void DefultChest()
    {
        if (_key >= 2)
        {
            _key -= 2;
            Prefs("Key", _key);
            if (Random.Range(1, 5) == 3)
            {
                _goldKey++;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "1";
            }
            else if (Random.Range(1, 50) == 15)
            {
                _goldKey += 2;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "2";
            }
        }
    }

    public void GoldChest2()
    {
        if (_goldKey >= 1)
        {
            _goldKey--;
            Prefs("GoldKey", _goldKey);
            if (Random.Range(1, 5) == 3)
            {
                _goldKey += 2;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "2";
            }
            else if (Random.Range(1, 50) == 15)
            {
                _goldKey += 3;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "3";
            }
        }
    }
    public void GoldChest1()
    {
        if (_goldKey >= 2)
        {
            _goldKey -= 2;
            Prefs("GoldKey", _goldKey);
            if (Random.Range(1, 5) == 3)
            {
                _goldKey += 3;
                Count("GoldKey", _goldKey, _goldKeyText);
                WinningSize(2, 1.5f);
                _sizeEffect.text = "3";
            }
            else if (Random.Range(1, 50) == 15)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 100;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "100";
                }
            }
        }
    }
    public void GoldChest()
    {
        if (_goldKey >= 3)
        {
            _goldKey -= 3;
            Prefs("GoldKey", _goldKey);
            if (Random.Range(1, 5) == 3)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 100;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "100";
                }
            }
            else if (Random.Range(1, 50) == 15)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 300;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "300";
                }
            }
        }
    }

    public void DiamondChest2()
    {
        if (_coin >= 100)
        {
            _coin -= 100;
            Prefs("Coin", _coin);
            if (Random.Range(1, 5) == 3)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 300;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "300";
                }
            }
            else if (Random.Range(1, 50) == 15)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 500;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "500";
                }
            }
        }
    }
    public void DiamondChest1()
    {
        if (_coin >= 300)
        {
            _coin -= 300;
            Prefs("Coin", _coin);
            if (Random.Range(1, 5) == 3)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 800;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "500";
                }
            }
            else if (Random.Range(1, 50) == 15)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 1500;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "1500";
                }
            }
        }
    }
    public void DiamondChest()
    {
        if (_coin >= 500)
        {
            _coin -= 500;
            Prefs("Coin", _coin);
            if (Random.Range(1, 5) == 3)
            {
                for (int i = 0; i < _coinText.Length; i++)
                {
                    _coin += 1500;
                    Count("Coin", _coin, _coinText[i]);
                    WinningSize(0, 1f);
                    _sizeEffect.text = "1500";
                }
            }
        }
    }

    public void ExitWinning()
    {
        _winning.SetActive(false);
        Time.timeScale = 0;
    }
}
