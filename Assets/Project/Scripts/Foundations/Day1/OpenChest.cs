using System;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    [SerializeField] private bool hasKey = false;
    [SerializeField] private int gold = 100;
    private int playerGold = 0;

    private void Start()
    {
        Debug.Log("Player is opening the chest...");

        if (hasKey)
        {
            playerGold += gold;
            Debug.Log($"Chest opened! Player receives {playerGold} gold.");
        }
        else
        {
            Debug.Log("Chest is locked! You need a key to open it.");
        }
    }
}
