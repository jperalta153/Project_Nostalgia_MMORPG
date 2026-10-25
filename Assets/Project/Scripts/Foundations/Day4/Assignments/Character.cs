using UnityEngine;

public class Character
{
    public string Name { get; private set; }
    public int MaxHealth { get; private set; }
    public int Health { get; private set; }
    public int AttackPower { get; private set; }

    public bool IsAlive
    {
        get { return Health > 0; }
    }

    public Character(string name, int maxHealth, int attackPower)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        AttackPower = attackPower;
    }

    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;

        Health -= damage;

        Health = Mathf.Max(0, Health);
    }

    public void Heal(int amount)
    { 
        if (amount <= 0) return;

        int newHealth = Health + amount;

        if (newHealth > MaxHealth)
        {
            Health = MaxHealth;
        }
        else
        {
            Health = newHealth;
        }
    }

    public void Attack(Character target)
    {
        if (target == null || !target.IsAlive || !this.IsAlive) return;

        target.TakeDamage(AttackPower);
    }
}
