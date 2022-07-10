using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableObjectPool : ScriptableObject
{
    [SerializeField] private GameObject prefab;
    private List<GameObject> _objectPool;

    public void Init(int count)
    {
        _objectPool = new List<GameObject>();
        for (int i = 0; i < count; i++)
        {
            var gameObject = Instantiate(prefab);
            gameObject.SetActive(false);
            gameObject.hideFlags = HideFlags.HideInHierarchy;
            _objectPool.Add(gameObject);
        }
    }

    public GameObject GetFromPool()
    {
        if (_objectPool.Count == 0)
        {
            Debug.LogWarning("No more objects in pool, creating new...");
            return Instantiate(prefab);
        }
        var gameObject = _objectPool.Last();
        _objectPool.Remove(gameObject);
        gameObject.SetActive(true);
        gameObject.hideFlags = HideFlags.None;
        return gameObject;
    }

    public void ReturnToPool(GameObject gameObject)
    {
        gameObject.SetActive(false);
        gameObject.hideFlags = HideFlags.HideInHierarchy;
        _objectPool.Add(gameObject);
    }
}
