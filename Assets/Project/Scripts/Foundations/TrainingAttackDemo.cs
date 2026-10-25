using UnityEngine;

public class TrainingAttackDemo : MonoBehaviour
{
    private void Start()
    {
        int totalDamage = 0;

        for (int hit = 1; hit <= 3; hit++)
        {
            int damage = CalculateDamage(7, 2);
            totalDamage += damage;
            Debug.Log($"Hit {hit}: {damage}");
        }

        Debug.Log($"Total damage: {totalDamage}");
    }

    int CalculateDamage(int attack, int defense)
    {
        int damage = attack - defense;
        return Mathf.Max(1, damage);
    }
}
