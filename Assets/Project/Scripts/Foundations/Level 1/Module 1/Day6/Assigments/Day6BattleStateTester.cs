using UnityEngine;

public class Day6BattleStateTester : MonoBehaviour
{
    private BattleState currentState = BattleState.NotStarted;

    private int playerHealth = 30;
    private int enemyHealth = 24;

    private const int playerDamage = 8;
    private const int enemyDamage = 5;

    private Character player;
    private Character slime;

    private void Start()
    {
        player = new Character("Vecto", 20, 6);
        slime = new Character("Slime", 10, 2);

        currentState = BattleState.PlayerTurn;
        RunBattle();
    }

    private void RunBattle()
    {
        int turns = 0;

        while (currentState != BattleState.Victory &&
               currentState != BattleState.Defeat &&
               turns < 20)
        {
            switch(currentState)
            {
                case BattleState.PlayerTurn:
                    PlayerAttack();
                    Debug.Log($"{player.Name} attacked {slime.Name}. {slime.Name} current health is {slime.Health}hp");
                    break;

                case BattleState.EnemyTurn:
                    EnemyAttack();
                    Debug.Log($"{slime.Name} attacked {player.Name}. {player.Name} current health is {player.Health}hp");
                    break;

                default:
                    Debug.LogError("Unexpected battle state!");
                    return;
            }

            turns++;
        }

        if (currentState == BattleState.Victory)
        {
            Debug.Log($"{player.Name} won!");
        } else
        {
            Debug.Log($"{slime.Name} won!");
        }
        
    }

    private void PlayerAttack()
    {
        if (currentState != BattleState.PlayerTurn)
            return;

        slime.TakeDamage(player.AttackPower);

        if (!slime.IsAlive)
        {
            currentState = BattleState.Victory;
        } else
        {
            currentState = BattleState.EnemyTurn;
        }
    }

    private void EnemyAttack()
    {
        if (currentState != BattleState.EnemyTurn)
            return;

        player.TakeDamage(slime.AttackPower);

        if (!player.IsAlive)
        {
            currentState = BattleState.Defeat;
        } else
        {
            currentState = BattleState.PlayerTurn;
        }
    }
}
