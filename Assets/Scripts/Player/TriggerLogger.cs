using UnityEngine;

public class TriggerLogger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger entered by: " + other.name);
    }
}

