using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float speedMultiplier = 1f;
    private Vector2 movementInput;

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float safeSpeed = Mathf.Max(0, movementSpeed);

        Vector2 direction = Vector2.ClampMagnitude(movementInput, 1f);
        Vector2 movement = direction * safeSpeed * speedMultiplier * Time.deltaTime;
        transform.position += new Vector3(movement.x, movement.y, 0f);
    }
}
