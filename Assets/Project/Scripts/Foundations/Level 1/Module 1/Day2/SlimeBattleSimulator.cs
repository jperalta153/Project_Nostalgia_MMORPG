using UnityEngine;

public class SlimeBattleSimulator : MonoBehaviour
{
    [SerializeField] private int attackPower = 8;
    [SerializeField] private int slimeCount = 3;

    private void Start()
    {
        int totalDamage = 0;
        int totalGold = 0;

        for (int slime = 0; slime < slimeCount; slime++)
        {
            int slimeLevel = slime + 1;
            int slimeDefense = slimeLevel;

            int damage = CalculateDamage(attackPower, slimeDefense);
            int goldReward = CalculateGoldReward(slimeLevel);

            totalDamage += damage;
            totalGold += goldReward;

            Debug.Log($"Slime {slime + 1} (Level {slimeLevel}) - Damage: {damage}, Gold Reward: {goldReward}");
        }

        Debug.Log($"Total Damage: {totalDamage}, Total Gold Reward: {totalGold}");
    }

    private int CalculateDamage(int attack, int defense)
    {
        return Mathf.Max(1, attack - defense);
    }

    private int CalculateGoldReward(int level)
    {
        return level * 4;
    }
}
