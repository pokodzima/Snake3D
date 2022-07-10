using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialLastChain : MonoBehaviour
{
    [SerializeField] private GameObject initialLastChain;
    [SerializeField] private PlayerData playerData;
    
    void Start()
    {
        playerData.lastChainGameObject = initialLastChain;
        playerData.currentSnakeSize = 3;
    }
    
}
