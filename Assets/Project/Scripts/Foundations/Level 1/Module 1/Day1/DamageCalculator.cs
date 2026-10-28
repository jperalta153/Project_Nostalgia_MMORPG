using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    [SerializeField] private int playerHealth = 100;
    [SerializeField] private int enemyAttackDamage = 20;

    private void Start()
    {
        if (enemyAttackDamage < 0)
        {
            Debug.LogError("Enemy attack damage cannot be negative.");
            return;
        }

        if (playerHealth < 0)
        {
            Debug.LogError("Player health cannot be negative.");
            return;
        }

        Debug.Log($"Player received {enemyAttackDamage} damage from enemy.");
        Debug.Log($"Calculating damage...");

        playerHealth -= enemyAttackDamage;

        if (playerHealth > 0)
        {
            Debug.Log($"Player survives with {playerHealth} health!");
        }
        else
        {
            playerHealth = 0;
            Debug.Log($"Player defeated! Health: {playerHealth}");
        }
    }
}
