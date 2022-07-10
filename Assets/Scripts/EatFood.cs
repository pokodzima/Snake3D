using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private ItemsData itemsData;
    [SerializeField] private ScriptableObjectPool chainPool;
    private const string FoodTag = "Food";
    private void AddChain()
    {
        if (playerData.maxSnakeSize == playerData.currentSnakeSize) return;

        var chain = chainPool.GetFromPool();
        
        var position = playerData.lastChainGameObject.transform.position -
                       playerData.lastChainGameObject.transform.forward;
        chain.transform.position = position;
        chain.transform.rotation = playerData.lastChainGameObject.transform.rotation;
        chain.transform.parent = transform.parent;
        
        chain.GetComponent<ConfigurableJoint>().connectedBody =
            playerData.lastChainGameObject.GetComponent<Rigidbody>();
        
        playerData.lastChainGameObject = chain;

        playerData.currentSnakeSize++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(FoodTag))
        {
            itemsData.currentFoodOnSceneCount--;
            AddChain();
            other.GetComponent<SendFoodToPool>().SendBackToPool();
        }
    }
}