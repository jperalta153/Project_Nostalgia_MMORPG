using UnityEngine;

public enum NPCState
{
    Idle,
    Patrolling,
    Talking
}

public class Day6NPCStateDemo : MonoBehaviour
{
    private NPCState currentState = NPCState.Idle;

    private void Start()
    {
        PrintCurrentState();

        currentState = NPCState.Patrolling;
        PrintCurrentState();

        currentState = NPCState.Talking;
        PrintCurrentState();
    }

    private void PrintCurrentState()
    {
        switch (currentState)
        {
            case NPCState.Idle:
                Debug.Log("NPC is resting.");
                break;

            case NPCState.Patrolling:
                Debug.Log("NPC is patrolling.");
                break;

            case NPCState.Talking:
                Debug.Log("NPC is talking.");
                break;
        }
    }
}
