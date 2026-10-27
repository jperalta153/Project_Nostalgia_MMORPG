using UnityEngine;

public class GoblinUnit : CombatUnit
{
    public GoblinUnit(string name, int health) : base(name, health)
    {
    }

    public override int GetAttackDamage()
    {
        int attackDamage = 5;
        return attackDamage;
    }
}
