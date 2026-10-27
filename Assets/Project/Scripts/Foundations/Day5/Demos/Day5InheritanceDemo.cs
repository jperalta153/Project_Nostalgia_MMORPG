using System.Collections.Generic;
using UnityEngine;

public class Day5InheritanceDemo : MonoBehaviour
{
    void Start()
    {
        List<Creature> creatures = new List<Creature>
        {
            new Creature("Traveler", 30),
            new Slime("Green Slime", 20),
            new Slime("Blue Slime", 25)
        };

        foreach (Creature creature in creatures)
        {
            Debug.Log(creature.TakeTurn());
        }
    }
}
