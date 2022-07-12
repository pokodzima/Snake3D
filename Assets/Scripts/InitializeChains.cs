using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InitializeChains : MonoBehaviour
{
    [SerializeField] private GameObject[] initialChains;
    [SerializeField] private PlayerData playerData;
    
    void Start()
    {
        playerData.chainList = initialChains.ToList();
    }
    
}
