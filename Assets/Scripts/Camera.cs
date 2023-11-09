using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private CarMovement _car;

    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _car = FindObjectOfType<CarMovement>();
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position + _offset;
    }
}
