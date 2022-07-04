using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveHorizontal;
    private float moveVertical;
    private float speed = 10.0f;
    private Rigidbody rb;
    private Vector3 direction;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        direction = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(direction * speed);
    }
}

