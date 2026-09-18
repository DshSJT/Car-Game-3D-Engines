using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Movement tuning (editable in Inspector )
    public float speed = 5.0f;
    public float turnSpeed = 100f;

    // Input system action exposed in Inspector for binding (WASD/Arrow keys)
    public InputAction moveAction;

    // Current input value (X = right/left, y = forward/backward), kept private for internal use
    private Vector2 moveInput;

    void Start()
    {
        // Enable the MoveAction so its starts reading input
        moveAction.Enable();
    }

    void Update()
    {
        // Read the 2D vector from the MoveAction (X: horizontal, y: vertical)
        moveInput = moveAction.ReadValue<Vector2>();

        // Move forward/backward along local Z using the y component
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);

        // Rotate around local Y using the X component
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}