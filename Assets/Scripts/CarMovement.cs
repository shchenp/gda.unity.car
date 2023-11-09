using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var position = gameObject.transform.position;
        
        var step = _speed * Time.deltaTime;
        
        if (Input.GetKey(KeyCode.W))
        {
            position.x += step;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            position.x -= step;
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            position.z += step / 2;
        }
        else if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)))
        {
            position.z -= step / 2;
        }

        transform.position = position;
    }
}
