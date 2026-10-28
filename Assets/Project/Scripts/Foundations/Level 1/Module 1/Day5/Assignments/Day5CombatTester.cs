using System.Collections.Generic;
using UnityEngine;

public class Day5CombatTester : MonoBehaviour
{
    void Start()
    {
        // 1. Create our combat units
        WarriorUnit warrior = new WarriorUnit("Hero", 100);
        SlimeUnit slime = new SlimeUnit("Green Slime", 20);
        GoblinUnit goblin = new GoblinUnit("Goblin", 25);

        // 2. Store all units in a list
        List<CombatUnit> units = new List<CombatUnit>
        {
            warrior,
            slime,
            goblin
        };

        // 3. Demonstrate polymorphism
        Debug.Log("=== ATTACK DAMAGE ===");

        foreach (CombatUnit unit in units)
        {
            Debug.Log(unit.Name + " deals " +
                      unit.GetAttackDamage() + " damage.");
        }

        // 4. Warrior attacks Slime
        Debug.Log("=== WARRIOR ATTACKS SLIME ===");

        slime.TakeDamage(warrior.GetAttackDamage());

        Debug.Log(slime.Name + " HP: " + slime.Health);

        // 5. Goblin attacks Warrior
        Debug.Log("=== GOBLIN ATTACKS WARRIOR ===");

        warrior.TakeDamage(goblin.GetAttackDamage());

        Debug.Log(warrior.Name + " HP: " + warrior.Health);

        // 6. Display everyone's remaining health
        Debug.Log("=== REMAINING HEALTH ===");

        foreach (CombatUnit unit in units)
        {
            Debug.Log(unit.Name + ": " +
                      unit.Health + " HP | Alive: " +
                      unit.IsAlive);
        }
    }
}
