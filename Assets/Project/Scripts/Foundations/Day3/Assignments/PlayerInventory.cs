using Unity.VisualScripting;
using System.Collections.Generic;
using UnityEngine;
using System;
using Mono.Cecil;

public class PlayerInventory : MonoBehaviour
{
    private int MAX_INVENTORY_SIZE = 5;

    // Create a List of strings to store the inventory items
    private List<string> inventory = new List<string>();

    private void Start()
    {
        AddItem("Small Potion");
        AddItem("Wooden Sword");
        AddItem("Small Potion");

        PrintInventory();

        Debug.Log($"Potion removed: {RemoveItem("Small Potion")}");

        PrintInventory();

        Debug.Log($"Missing item removed: {RemoveItem("Dragon Gem")}");

        AddItem("Small Potion");
        AddItem("Small Potion");
        AddItem("Small Potion");

        PrintInventory();

        Debug.Log($"Attempting to add more than {MAX_INVENTORY_SIZE} items in the inventory");

        AddItem("Wooden Sword");

        PrintInventory();
    }

    // Create a function that adds item to the inventory
    private bool AddItem(string itemName)
    {
        if (inventory.Count >= MAX_INVENTORY_SIZE)
        {
            return false;
        }

        inventory.Add(itemName);

        return true;
    }

    // Create a function that removes item in the inventory and return true if successful
    private bool RemoveItem(string itemName)
    {
        return inventory.Remove(itemName);
    }

    // Create function that displays item count and every item in the inventory
    private void PrintInventory()
    {
        Debug.Log($"Inventory ({inventory.Count}):");

        foreach (string itemName in inventory)
        {
            Debug.Log($"- {itemName}");
        }
    }
}
