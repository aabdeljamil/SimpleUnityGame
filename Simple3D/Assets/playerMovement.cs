using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private float movementInputDirection;
    private Rigidbody rb;
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, -1000);
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
    }

    void OnMove()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(movementSpeed * -1 * movementInputDirection, rb.velocity.y, rb.velocity.z);
    }
}
