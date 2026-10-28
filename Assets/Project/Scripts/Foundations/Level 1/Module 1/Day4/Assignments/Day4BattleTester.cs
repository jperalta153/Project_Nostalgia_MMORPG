
using UnityEngine;

public class Day4BattleTester : MonoBehaviour
{
    private void Start()
    {
        Character hero =
            new Character("Knight", 100, 25);

        Character slime =
            new Character("Slime", 40, 8);

        Character goblin =
            new Character("Goblin", 60, 12);

        // TODO:
        // 1. Hero attacks Slime.
        // 2. Slime attacks Hero.
        // 3. Hero heals for 10 HP.
        // 4. Hero attacks Slime again.
        // 5. Display everyone's remaining HP.
        // 6. Test invalid damage and healing.

        hero.Attack(slime);
        slime.Attack(hero);
        hero.Heal(10);
        hero.Attack(slime);

        Debug.Log($"{hero.Name} has {hero.Health} HP remaining.");
        Debug.Log($"{slime.Name} has {slime.Health} HP remaining.");
        Debug.Log($"{goblin.Name} has {goblin.Health} HP remaining.");
    }
}
