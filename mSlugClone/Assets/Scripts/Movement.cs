using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float moveSpeed = 0f;
    private Rigidbody2D rigidbody2D;
    private float jumpForce;
    private bool isJumping; 
    private float moveHorizontal;
    private float moveVertical; 

    // Update is called once per frame
    void Update()
    {
        //horizontalInput.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
       
    }
}
