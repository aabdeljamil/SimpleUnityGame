using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    private float movementInputDirection;
    public static Rigidbody rb;
    public float horizontalSpeed;
    public static float movementSpeed = 35;
    public float gravityScale = -3f;
    public float jumpSpeed = 20f;
    public float jumpShortSpeed = 10f;
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
        if (SceneManager.GetActiveScene().buildIndex != 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jumpPressed = jumpPressedTime;
            }
            if (Input.GetButtonUp("Jump") && !isGrounded)
            {
                jumpcancel = true;
            }
        }

    }

    void OnMove()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (movementSpeed > 35)
        {
            movementSpeed -= 1;
        }

        rb.velocity = new Vector3(horizontalSpeed * -1 * movementInputDirection, rb.velocity.y, -movementSpeed);
        jumpPressed -= Time.deltaTime;

        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            if (jumpcancel)
            {
                if (rb.velocity.y > jumpShortSpeed)
                {
                    rb.velocity = new Vector3(rb.velocity.x, jumpShortSpeed, rb.velocity.z);
                }
            }
            if (jumpPressed > 0 && isGrounded)
            {
                jumpPressed = 0;
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
                isGrounded = false;
            }

        }

       rb.velocity -= new Vector3(0,Physics.gravity.y * gravityScale * Time.deltaTime, 0);
        if (rb.velocity.z > -movementSpeed)
            rb.velocity += new Vector3(0, 0, 1);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb.velocity.z != 0 && collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
            jumpcancel = false;
        }
    }
}
