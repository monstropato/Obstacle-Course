using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    //STRING REFERENCES
    static string HORIZONTAL = "Horizontal";
    static string VERTICAL = "Vertical";


    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float xMovement = Input.GetAxis(HORIZONTAL) * Time.deltaTime * moveSpeed;
        float zMovement = Input.GetAxis(VERTICAL) * Time.deltaTime * moveSpeed;
        transform.Translate(xMovement, 0, zMovement);
    }
}
