using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float movementInputDirection;
    private Rigidbody rb;
    public float horizontalSpeed;
    public float movementSpeed;
    public float gravityScale = 1f;
    public float jumpSpeed = 10f;
    public float jumpShortSpeed = 5f;
    public bool isGrounded;
    public float jumpPressed;
    public float jumpPressedTime = .2f;
    public bool jumpcancel = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
        if (Input.GetButtonDown("Jump"))
        {
            jumpPressed = jumpPressedTime;
        }
        if (Input.GetButtonUp("Jump") && !isGrounded)
        {
            jumpcancel = true;
        }
    }

    void OnMove()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontalSpeed * -1 * movementInputDirection, rb.velocity.y, -movementSpeed);
        jumpPressed -= Time.deltaTime;

        if (jumpPressed > 0 && isGrounded)
        {
            jumpPressed = 0;
            rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            isGrounded = false;
        }

        if (jumpcancel)
        {
            if (rb.velocity.y > jumpShortSpeed)
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpShortSpeed, rb.velocity.z);
            }
        }

       rb.velocity -= new Vector3(0,Physics.gravity.y * gravityScale * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        jumpcancel = false;
    }
}
