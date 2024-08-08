using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBack : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Color[] _color;

    private void Start()
    {
        _camera.backgroundColor = _color[Random.Range(0, _color.Length)];
    }
}
