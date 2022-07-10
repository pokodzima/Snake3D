using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemsData : ScriptableObject
{
    public Vector3 spawnBoundaries;
    public Vector3 spawnPositionOffset;
    public int maxFoodOnSceneCount;
    public int currentFoodOnSceneCount;
    public float spawnRateInSeconds;
    public float spawnTimer;
}
