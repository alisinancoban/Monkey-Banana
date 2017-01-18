using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;

    public float moveSpeed = 5;

    private Vector3 moveVector = Vector3.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + moveVector);
    }

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");


        moveVector = (inputH * transform.right * moveSpeed) + (inputV * transform.forward * moveSpeed);
    }
}
