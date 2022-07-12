using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private ItemsData itemsData;
    [SerializeField] private ScriptableObjectPool chainPool;
    [SerializeField] private TimerData timerData;
    private const string FoodTag = "Food";
    private void AddChain()
    {
        var lastChain = playerData.chainList.Last();
        if (playerData.maxSnakeSize == playerData.chainList.Count) return;

        var chain = chainPool.GetFromPool();
        
        var position = lastChain.transform.position -
                       lastChain.transform.forward;
        chain.transform.position = position;
        chain.transform.rotation = lastChain.transform.rotation;
        chain.transform.parent = transform.parent;
        
        chain.GetComponent<ConfigurableJoint>().connectedBody =
            playerData.chainList.Last().GetComponent<Rigidbody>();
        
        playerData.chainList.Add(chain);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(FoodTag))
        {
            itemsData.currentFoodOnSceneCount--;
            AddChain();
            timerData.ResetTimer();
            other.GetComponent<SendFoodToPool>().SendBackToPool();
        }
    }
}