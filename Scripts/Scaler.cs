using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed = 0.3f;

    private Vector3 _scaleChange;

    private void Start()
    {
        _scaleChange = new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);
    }

    private void Update()
    {
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
