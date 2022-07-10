using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform playerSpawnPoint;

    private const string PlayerName = "Snake";
    private void Start()
    {
        var player = Instantiate(playerPrefab, playerSpawnPoint.position, playerSpawnPoint.rotation, null);
        player.name = PlayerName;
    }
}
