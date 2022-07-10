using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainPoolInitializer : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private ChainPool chainPool;

    private void Awake()
    {
        chainPool.Init(playerData.maxSnakeSize);
    }
}
