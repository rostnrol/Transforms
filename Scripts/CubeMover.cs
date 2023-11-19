using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 1000f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, -_rotationSpeed * Time.deltaTime, 0);

        transform.position += transform.forward * _movementSpeed * Time.deltaTime;
    }
}
