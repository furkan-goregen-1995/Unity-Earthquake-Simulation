﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PooledObject : MonoBehaviour, IPooledObject
{

    private Rigidbody _rb;

    public PooledObjectType Type;

    private float _timer = 5f;


    public virtual void OnObjectSpawn()
    {
        _rb.velocity = Vector3.zero;
    }

    public virtual void OnObjectDespawn()
    {

    }

    public virtual void Init()
    {
        _rb = GetComponent<Rigidbody>();
        AddRandomForce();
        _timer = 5f;
    }

    public virtual void AddRandomForce()
    {
        int value = 300;
        Vector3 random =
            new Vector3(Random.Range(-value, value),
                Random.Range(-value, value),
                Random.Range(-value, value));

        _rb.AddForce(random);
    }

    //private void Update()
    //{
    //    if (_timer > 0)
    //    {
    //        _timer -= Time.deltaTime;
    //    }
    //    else
    //    {
    //        ObjectPooler.Instance.Despawn(Type,gameObject);
    //    }
    //}

}