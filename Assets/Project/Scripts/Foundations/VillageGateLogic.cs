using UnityEngine;

public class VillageGateLogic : MonoBehaviour
{
    [SerializeField] private int playerLevel = 3;
    [SerializeField] private int requiredLevel = 5;
    [SerializeField] private bool hasForestPermit = false;

    private void Start()
    {
        Debug.Log("Checking forest entry requirements...");

        if (playerLevel >= requiredLevel && hasForestPermit)
        {
            Debug.Log("Gate opened! Welcome to the forest.");
        }
        else
        {
            if (playerLevel < requiredLevel && hasForestPermit)
            {
                Debug.Log($"Player level is {playerLevel}. Required level is {requiredLevel}.");
            } else if (playerLevel >= requiredLevel && !hasForestPermit)
            {
                Debug.Log("Player does not have a forest permit.");
            } else
            {
                Debug.Log($"Player level is {playerLevel}. Required level is {requiredLevel}. Player does not have a forest permit.");
            }
        }
    }
}
