using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveForward : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        _rigidbody.velocity = playerData.snakeForwardSpeed * transform.forward;
    }
}
