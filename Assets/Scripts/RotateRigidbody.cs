using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RotateRigidbody : MonoBehaviour
{
    [SerializeField] private InputData inputData;
    [SerializeField] private PlayerData playerData;

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        if (playerData.gameOver) return;
        _rigidbody.angularVelocity = new Vector3(0f, inputData.turnInput * playerData.snakeTurnSpeed, 0f);
    }
}
