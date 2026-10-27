using UnityEngine;

public class Creature
{
    public string Name { get; private set; }
    public int Health { get; private set; }

    public bool IsAlive => Health > 0;

    public Creature(string name, int health)
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
    }

    public virtual string TakeTurn()
    {
        return Name + " waits.";
    }
}
