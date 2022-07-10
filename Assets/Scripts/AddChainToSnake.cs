using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChainToSnake : MonoBehaviour
{
    [SerializeField] private GameObject chainPrefab;
    [SerializeField] private PlayerData playerData;

    private void Start()
    {
        InvokeRepeating(nameof(AddChain),5f, 5f);
    }

    private void AddChain()
    {
        var position = playerData.lastChainGameObject.transform.position -
                       playerData.lastChainGameObject.transform.forward;
        var chain = Instantiate(chainPrefab, position, playerData.lastChainGameObject.transform.rotation, transform);
        chain.GetComponent<ConfigurableJoint>().connectedBody =
            playerData.lastChainGameObject.GetComponent<Rigidbody>();
        playerData.lastChainGameObject = chain;
    }
}