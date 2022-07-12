using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DestroyChainOnTimer : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    [SerializeField] private TimerData timerData;

    [SerializeField] private ScriptableObjectPool chainPool;
    // Start is called before the first frame update
    void Start()
    {
        timerData.ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerData.gameOver) return;
        timerData.destroyChainTimer -= Time.deltaTime;
        if (timerData.destroyChainTimer <= 0f)
        {
            chainPool.ReturnToPool(playerData.chainList.Last());
            playerData.chainList.RemoveAt(playerData.chainList.Count - 1);
            timerData.ResetTimer();
            if (playerData.chainList.Count == 0)
            {
                playerData.gameOver = true;
            }
        }
    }
}
