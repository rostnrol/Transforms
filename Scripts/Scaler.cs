using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 0.3f;

    private Vector3 _scaleChange;

    void Start()
    {
        _scaleChange = new Vector3(scaleSpeed, scaleSpeed, scaleSpeed);
    }

    void Update()
    {
        transform.localScale += _scaleChange * Time.deltaTime;
    }
}
