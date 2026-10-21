using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerCollisionLogger : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Player collided with: {collision.gameObject.name} at {rb.position}");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // Contact is continuing.
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"Stopped colliding with: {collision.gameObject.name} at {rb.position}");
    }
}
