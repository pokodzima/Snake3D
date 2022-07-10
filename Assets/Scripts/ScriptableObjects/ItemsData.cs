using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemsData : ScriptableObject
{
    public Vector3 spawnBoundaries;
    public Vector3 spawnPositionOffset;
    public int maxFoodOnSceneCount;
    [NonSerialized]
    public int currentFoodOnSceneCount;
    public float spawnRateInSeconds;
    [NonSerialized]
    public float spawnTimer;
}
