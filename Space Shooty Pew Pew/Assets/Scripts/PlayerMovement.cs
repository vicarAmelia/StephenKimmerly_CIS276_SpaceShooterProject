using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveInput;
    private Rigidbody rb;
    [SerializeField] private float speed = 4f;
    public float xMovement;
    public float yMovement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    //Moves player left, right, up, and down
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x * speed, moveInput.z * speed);
        xMovement = Mathf.Clamp(xMovement, -867f, 856f);
        yMovement = Mathf.Clamp(yMovement, -82f, 667f);
    }
    //gives space for the move inputs to move in
    private void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
}
