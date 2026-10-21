using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movementInput;

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector2 direction = Vector2.ClampMagnitude(movementInput, 1f);

        if (direction.sqrMagnitude == 0f) return;

        float safeSpeed = Mathf.Clamp(movementSpeed, 0, 10);

        Vector2 movement = direction * safeSpeed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + movement);
    }
}
