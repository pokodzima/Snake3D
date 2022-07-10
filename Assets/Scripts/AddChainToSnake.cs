using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChainToSnake : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private ScriptableObjectPool chainPool;

    private void Start()
    {
        InvokeRepeating(nameof(AddChain), 5f, 5f);
    }

    private void AddChain()
    {
        if (playerData.maxSnakeSize == playerData.currentSnakeSize) return;

        var chain = chainPool.GetFromPool();
        
        var position = playerData.lastChainGameObject.transform.position -
                       playerData.lastChainGameObject.transform.forward;
        chain.transform.position = position;
        chain.transform.rotation = playerData.lastChainGameObject.transform.rotation;
        chain.transform.parent = transform;
        
        chain.GetComponent<ConfigurableJoint>().connectedBody =
            playerData.lastChainGameObject.GetComponent<Rigidbody>();
        
        playerData.lastChainGameObject = chain;

        playerData.currentSnakeSize++;
    }
}