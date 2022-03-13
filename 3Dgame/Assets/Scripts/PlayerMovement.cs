using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private int points = 0;

    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 7f;

    [SerializeField] Transform groundChecker;
    [SerializeField] LayerMask ground;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontal * speed, rb.velocity.y, vertical*speed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();    
        }

        OnTriggerEnter(GetComponent<Collider>());
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyHead"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
            points++;
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundChecker.position, .1f, ground); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            points++;
            Debug.Log(points);
        }
    }
}
