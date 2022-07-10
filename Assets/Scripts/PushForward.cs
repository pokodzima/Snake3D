using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushForward : MonoBehaviour
{
    [SerializeField] private float velocity;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        _rigidbody.velocity = velocity * transform.forward;
    }
}
