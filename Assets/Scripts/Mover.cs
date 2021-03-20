using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpForce = 10f;

    //STRING REFERENCES
    static string HORIZONTAL = "Horizontal";
    static string VERTICAL = "Vertical";
    static string JUMP = "Jump";

    Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        float xMovement = Input.GetAxis(HORIZONTAL) * Time.deltaTime * moveSpeed;
        float zMovement = Input.GetAxis(VERTICAL) * Time.deltaTime * moveSpeed;
        transform.Translate(xMovement, 0, zMovement);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = new Vector3(0, jumpForce, 0);
        }
    }
}
