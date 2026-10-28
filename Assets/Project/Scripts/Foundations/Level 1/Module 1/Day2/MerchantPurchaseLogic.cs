using UnityEngine;

public class MerchantPurchaseLogic : MonoBehaviour
{
    private void Start()
    {
        int playerGold = 0;
        int potionPrice = 50;
        int playerPotions = 0;

        Debug.Log($"Player has {playerGold} gold and {playerPotions} potions.");

        if (playerGold >= potionPrice)
        {
            playerGold -= potionPrice;
            playerPotions++;
            Debug.Log($"Player purchased a potion for {potionPrice} gold. Remaining gold: {playerGold}. Potion count: {playerPotions}");
        }
        else
        {
            Debug.Log($"Player does not have enough gold to purchase a potion. Remaining gold: {playerGold}. Potion count: {playerPotions}");
        }
    }
}
