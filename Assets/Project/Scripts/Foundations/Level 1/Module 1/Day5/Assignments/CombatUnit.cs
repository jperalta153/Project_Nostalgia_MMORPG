using UnityEngine;

public class CombatUnit
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public bool IsAlive => Health > 0;

    public CombatUnit(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0 || !IsAlive)
        {
            return;
        }

        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
        }
    }

    public virtual int GetAttackDamage()
    {
        int attackDamage = 1;
        return attackDamage;
    }
}
