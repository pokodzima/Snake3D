using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RotateRigidbody : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private InputData inputData;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        _rigidbody.angularVelocity = new Vector3(0f, inputData.turnInput * velocity, 0f);
    }
}
