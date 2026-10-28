using UnityEngine;

public class EnemyWaveManager : MonoBehaviour
{
    private string[] enemies =
    {
        "Slime",
        "Wolf",
        "Slime",
        "Bat"
    };

    [SerializeField] private string targetEnemy = "Wolf";

    private void Start()
    {
        PrintWave();

        Debug.Log($"{targetEnemy}s: {CountEnemies(targetEnemy)}");
    }

    private void PrintWave()
    {
        Debug.Log("Enemies in this wave:");

        for (int enemyPos = 0; enemyPos < enemies.Length; enemyPos++)
        {
            Debug.Log($"{enemyPos + 1}. {enemies[enemyPos]}");
        }
    }

    private int CountEnemies(string targetName)
    {
        int count = 0;

        foreach (string enemy in enemies)
        {
            string enemyLowerCase = enemy.ToLower();
            string targetLowerCase = targetName.ToLower();

            if (enemyLowerCase == targetLowerCase)
            {
                count++;
            }
        }

        return count;
    }
}
