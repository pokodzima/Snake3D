using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class ChainPool : ScriptableObject
{
    [SerializeField] private GameObject chainPrefab;
    private List<GameObject> _chainsList;

    public void Init(int count)
    {
        _chainsList = new List<GameObject>();
        for (int i = 0; i < count; i++)
        {
            var chain = Instantiate(chainPrefab);
            chain.SetActive(false);
            chain.hideFlags = HideFlags.HideInHierarchy;
            _chainsList.Add(chain);
        }
    }

    public GameObject GetFromPool()
    {
        if (_chainsList.Count == 0)
        {
            Debug.LogWarning("No more chains in Pool, Creating new Chain...");
            return Instantiate(chainPrefab);
        }
        var chain = _chainsList.Last();
        _chainsList.Remove(chain);
        chain.SetActive(true);
        chain.hideFlags = HideFlags.None;
        return chain;
    }

    public void ReturnToPool(GameObject chain)
    {
        chain.SetActive(false);
        chain.hideFlags = HideFlags.HideInHierarchy;
        _chainsList.Add(chain);
    }
}
