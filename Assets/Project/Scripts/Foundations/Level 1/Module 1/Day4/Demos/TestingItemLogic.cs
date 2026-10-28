using UnityEngine;

public class TestingItemLogic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Item healthPotion = new Item("Health Potion", 25, 4);
        Item ironSword = new Item("Iron Sword", 150, 2);
        Item magicScroll = new Item("Magic Scroll", 80, 3);

        Debug.Log($"{healthPotion.quantity} {healthPotion.itemName} costs {healthPotion.GetTotalValue()}");
        Debug.Log($"{ironSword.quantity} {ironSword.itemName} costs {ironSword.GetTotalValue()}");
        Debug.Log($"{magicScroll.quantity} {magicScroll.itemName} costs {magicScroll.GetTotalValue()}");
    }
}
