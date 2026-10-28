using UnityEngine;

public class SlimeUnit : CombatUnit
{
    public SlimeUnit(string name, int health) : base(name, health)
    {
    }

    public override int GetAttackDamage()
    {
        int attackDamage = 3;
        return attackDamage;
    }
}
