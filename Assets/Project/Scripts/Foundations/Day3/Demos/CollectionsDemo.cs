using System.Collections.Generic;
using UnityEngine;

public class CollectionsDemo : MonoBehaviour
{
    private string[] enemies =
    {
        "Slime",
        "Wolf",
        "Bat"
    };

    private List<string> inventory = new List<string>();

    private void Start()
    {
        Debug.Log("=== Enemy List ===");

        for (int i = 0; i < enemies.Length; i++)
        {
            Debug.Log($"Enemy {i + 1}: {enemies[i]}");
        }

        Debug.Log("=== Player Inventory ===");

        inventory.Add("Wooden Sword");
        inventory.Add("Health Potion");
        inventory.Add("Leather Armor");

        PrintInventory();

        inventory.Remove("Health Potion");

        Debug.Log("=== After Using Potion ===");

        PrintInventory();
    }

    private void PrintInventory()
    {
        Debug.Log($"Total items: {inventory.Count}");

        foreach (string item in inventory)
        {
            Debug.Log(item);
        }
    }
}
