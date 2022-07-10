using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolInitializer : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private ItemsData itemsData;
    
    [SerializeField] private ScriptableObjectPool chainPool;
    [SerializeField] private ScriptableObjectPool cubeFoodRedPool;
    [SerializeField] private ScriptableObjectPool cubeFoodGreenPool;
    [SerializeField] private ScriptableObjectPool cubeFoodBluePool;

    private void Awake()
    {
        chainPool.Init(playerData.maxSnakeSize);
        cubeFoodRedPool.Init(itemsData.maxFoodOnSceneCount);
        cubeFoodBluePool.Init(itemsData.maxFoodOnSceneCount);
        cubeFoodGreenPool.Init(itemsData.maxFoodOnSceneCount);
    }
}
