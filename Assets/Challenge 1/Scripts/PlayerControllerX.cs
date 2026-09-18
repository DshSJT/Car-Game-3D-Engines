using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed;
    public float pitchSpeed = 100.0f;

    // Input system action exposed in Inspector for binding (WASD/Arrow keys)
    public InputAction moveAction;

    // Up/Down arrow keys
    public InputAction pitchAction;

    private Vector2 moveInput;
    private float pitchInput;

    void Start()
    {
        moveAction.Enable();
        pitchAction.Enable();
    }

    void FixedUpdate()
    {
        moveInput = moveAction.ReadValue<Vector2>();
        pitchInput = pitchAction.ReadValue<float>();

        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.right * Time.deltaTime * pitchSpeed * pitchInput);
    }
}
