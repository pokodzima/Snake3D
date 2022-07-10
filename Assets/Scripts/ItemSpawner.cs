using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private ItemsData itemsData;

    [SerializeField] private ScriptableObjectPool[] foodPools;

    void Start()
    {
        itemsData.spawnTimer = itemsData.spawnRateInSeconds;
    }


    void Update()
    {
        if (itemsData.currentFoodOnSceneCount == itemsData.maxFoodOnSceneCount) return;

        itemsData.spawnTimer -= Time.deltaTime;
        
        if (itemsData.spawnTimer <= 0f)
        {
            var item = foodPools[Random.Range(0, foodPools.Length)].GetFromPool();
            item.transform.position =
                new Vector3(Random.Range(-itemsData.spawnBoundaries.x, itemsData.spawnBoundaries.x),
                    Random.Range(-itemsData.spawnBoundaries.y, itemsData.spawnBoundaries.y),
                    Random.Range(-itemsData.spawnBoundaries.z, itemsData.spawnBoundaries.z)) +
                itemsData.spawnPositionOffset;
            itemsData.spawnTimer = itemsData.spawnRateInSeconds;

            itemsData.currentFoodOnSceneCount++;
        }
    }
}