using UnityEngine;

public class PotionRestock : MonoBehaviour
{
    private const int MAX_POTION_COUNT = 5;

    private int potionCount = 1;

    private void Start()
    {
        while (potionCount < MAX_POTION_COUNT)
        {
            potionCount++;
            Debug.Log($"Potion count: {potionCount}");
        }

        Debug.Log($"Potion restock complete. Potion count: {potionCount}");
    }
}
