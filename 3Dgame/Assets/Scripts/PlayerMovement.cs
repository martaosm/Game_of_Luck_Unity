using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector3(0, 7f, 0);
        }
        if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0, 0, 5f);
        }
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(5f, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(0, 0, -5f);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-5f, 0, 0);
        }
    }
}
