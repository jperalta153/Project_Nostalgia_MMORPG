using UnityEngine;

public class Slime : Creature
{
    public Slime(string name, int health) : base(name, health)
    {
    }

    public override string TakeTurn()
    {
        return Name + " bounces toward the enemy.";
    }
}
