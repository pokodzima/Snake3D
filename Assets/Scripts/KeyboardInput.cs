using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private const string TurnAxisName = "Horizontal";
    [SerializeField] private InputData inputData;
    [SerializeField] private PlayerData playerData;

    private void Update()
    {
        if (playerData.gameOver) return;
        SetTurnRate();
    }

    private void SetTurnRate()
    {
        inputData.turnInput = Input.GetAxis(TurnAxisName);
    }
}