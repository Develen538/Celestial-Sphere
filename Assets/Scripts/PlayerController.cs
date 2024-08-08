using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using Unity.VisualScripting;
using UnityEngine.U2D;
using System.Drawing;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] Slider _slider;
    [SerializeField] private ChestManager _chest;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _menu;
    [SerializeField] private TMP_Text _bonusCounterText;

    private AudioSource _audio;
    private Vector2 _startPos;
    private int _bonusCount;

    void Start()
    {
        if (PlayerPrefs.HasKey("volume3"))
        {
            _slider.value = PlayerPrefs.GetFloat("volume3");
        }
        _audio = GetComponent<AudioSource>();
        _bonusCount = Random.Range(1,15);
        UpdateBonusCounter();
    }

    private void Update()
    {
        if (_slider.value != _audio.volume)
        {
            PlayerPrefs.SetFloat("volume3", _slider.value);
            _audio.volume = _slider.value;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            SceneManager.LoadScene(0);
            _menu.SetActive(true);
            Time.timeScale = 0;
        }

        if (collision.gameObject.TryGetComponent(out Bonus bonus))
        {

            _bonusCount--;

            UpdateBonusCounter();
            _chest._coin++;
            for (int i = 0; i < _chest._coinText.Length; i++)
            {
                _chest._coinText[i].text = "" +_chest._coin;
            }
            PlayerPrefs.SetInt("Coin", _chest._coin);
            PlayerPrefs.Save();

            if (_bonusCount == 0)
            {
                SceneManager.LoadScene(0);
                _menu.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (collision.gameObject.TryGetComponent(out Bonus component))
        {
            _audio.Play();
        }
            
    }

    private async void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Wall wall))
        {
            _moveSpeed = 0;
            transform.position = new Vector2(-2f, -4.4f);
            await Pause();
            _moveSpeed = 0.05f;
        }
        if (collision.gameObject.TryGetComponent(out RightWall wall2))
        {
            _moveSpeed = 0;
            transform.position = new Vector2(2f, -4.4f);
            await Pause();
            _moveSpeed = 0.05f;
        }
    }

    public async Task Pause()
    {
        await Task.Delay(100);
    }

    private void UpdateBonusCounter()
    {
        _bonusCounterText.text = "Осталось собрать: " + _bonusCount.ToString();
    }

    private void Move()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    _startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    Vector2 dir = touch.position - _startPos;
                    Vector2 pos = transform.position + new Vector3(dir.x, 0.5f);
                    transform.position = Vector3.Lerp(transform.position, pos, _moveSpeed * Time.deltaTime);
                    break;
            }
        }
    }
}

