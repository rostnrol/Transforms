using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMover : MonoBehaviour
{
    private float _speed = 1f;
   
    private void Update()
    {
        transform.Translate(-transform.forward * _speed * Time.deltaTime);
    }
}
