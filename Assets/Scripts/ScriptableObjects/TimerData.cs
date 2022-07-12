using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TimerData : ScriptableObject
{
    [NonSerialized] public float destroyChainTimer;
    public float timeToDestroyChain;

    public void ResetTimer()
    {
        destroyChainTimer = timeToDestroyChain;
    }
}
