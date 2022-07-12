using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EatTimerUI : MonoBehaviour
{
    [SerializeField] private TimerData timerData;
    [SerializeField] private PlayerData playerData;

    private TextMeshProUGUI _textMesh;
    // Start is called before the first frame update
    void Start()
    {
        _textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerData.gameOver)
        {
            _textMesh.enabled = false;
            return;
        }
        _textMesh.text = $"Eat Timer: {(int)timerData.destroyChainTimer + 1}";
    }
}
