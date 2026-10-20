using UnityEngine;

public class PlayerIdentity : MonoBehaviour
{
    [SerializeField] private string characterName = "Adventurer";
    [SerializeField] private int characterLevel = 1;

    private void Start()
    {
        Debug.Log("Welcome to Project Nostalgia!");
        Debug.Log("Character: " + characterName);
        Debug.Log("Level: " + characterLevel);
        Debug.Log("Spawn Position: " + transform.position);
    }

    private void Update()
    {

    }

}
