using UnityEngine;

public class WarriorUnit : CombatUnit
{
    public WarriorUnit(string name, int health) : base(name, health)
    { 
    }

    public override int GetAttackDamage()
    {
        int attackDamage = 7;
        return attackDamage;
    }
}
