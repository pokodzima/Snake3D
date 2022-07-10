using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
   [NonSerialized]
   public GameObject lastChainGameObject;
   
   public int maxSnakeSize;
   [NonSerialized]
   public int currentSnakeSize;

   public float snakeForwardSpeed;
   public float snakeTurnSpeed;

}
