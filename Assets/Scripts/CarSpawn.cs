using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _car;
    [SerializeField] private Transform _parent;

    private void Awake()
    {
        Instantiate(_car, _parent);
    }
}
