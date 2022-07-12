using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    [NonSerialized] public List<GameObject> chainList;

    public int maxSnakeSize;

    public float snakeForwardSpeed;
    public float snakeTurnSpeed;

    [NonSerialized] public bool gameOver;
}