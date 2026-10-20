using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int baseHealth = 100;
    [SerializeField] private int strength = 10;
    [SerializeField] private int weaponDamage = 5;
    [SerializeField] private int gold = 100;
    [SerializeField] private int armor = 5;
    [SerializeField] private float baseSpeed = 3.5f;
    [SerializeField] private float speedBonus = 0.5f;

    private void Start()
    {
        int maxHealth = CalculateMaxHealth();
        int attackDamage = CalculateAttackDamage();
        int remainingGold = CalculateRemainingGold(20);
        int defense = CalculateDefense();

        Debug.Log($"Max health: {maxHealth}");
        Debug.Log($"Attack damage: {attackDamage}");
        Debug.Log($"Remaining gold: {remainingGold}");
        Debug.Log($"Defense: {defense}");
        Debug.Log($"Movement speed: {CalculateMovementSpeed()}");
        Debug.Log($"Skill damage with skill power 15: {CalculateSkillDamage(15)}");
        Debug.Log($"Experience reward for defeating a level 1 monster: {CalculateExperienceReward(1)}");
        Debug.Log($"Experience reward for defeating a level 5 monster: {CalculateExperienceReward(5)}");
        Debug.Log($"Experience reward for defeating a level 3 monster: {CalculateExperienceReward(3)}");
    }

    private int CalculateMaxHealth()
    {
        int bonusHealth = strength * 5;
        return baseHealth + bonusHealth;
    }

    private int CalculateAttackDamage()
    {
        int strengthDamage = strength * 2;
        return strengthDamage + weaponDamage;
    }

    private int CalculateRemainingGold(int itemCost)
    {
        return gold - itemCost;
    }

    private int CalculateDefense()
    {
        return strength * 1 + armor;
    }

    private int CalculateExperienceReward(int monsterLevel)
    {
        return monsterLevel * 10;
    }

    private float CalculateMovementSpeed()
    {
        return baseSpeed + speedBonus;
    }

    private int CalculateSkillDamage(int skillPower)
    {
        return CalculateAttackDamage() + skillPower;
    }
}
