using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnGameOver : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private void Update()
    {
        transform.GetChild(0).gameObject.SetActive(playerData.gameOver);
    }
}
