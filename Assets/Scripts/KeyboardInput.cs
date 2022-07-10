using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private const string TurnAxisName = "Horizontal";
    [SerializeField] private InputData inputData;

    private void Update()
    {
        SetTurnRate();
    }

    private void SetTurnRate()
    {
        inputData.turnInput = Input.GetAxis(TurnAxisName);
    }
}