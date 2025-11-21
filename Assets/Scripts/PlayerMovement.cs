using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public float groundCheckRadius = 0.2f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private Animator playerAnimator;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if (moveInput > 0)
        {
            transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        }
        else if (moveInput < 0)
        {
            transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
        }

        SetAnimation(moveInput);
    }

    private void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    private void SetAnimation(float moveInput)
    {
        playerAnimator.SetFloat("Speed", Mathf.Abs(moveInput));
        playerAnimator.SetBool("IsGrounded", isGrounded);
        playerAnimator.SetFloat("VelocityY", rb.velocity.y);
    }
}
