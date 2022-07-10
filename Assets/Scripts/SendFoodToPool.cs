using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendFoodToPool : MonoBehaviour
{
    [SerializeField] private ScriptableObjectPool pool;

    public void SendBackToPool()
    {
        pool.ReturnToPool(gameObject);
    }
}