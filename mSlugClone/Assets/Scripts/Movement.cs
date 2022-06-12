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
    private bool canJump; 

    private void Start()
    {
        // This is the line of code for grabbing any coponent
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 1f;
        jumpForce = 30f;
        isJumping = false;
        canJump = true; 

    }


    // Update is called once per frame
    void Update()
    {

        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        // If we are running left or right
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rigidbody2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0), ForceMode2D.Impulse); 

        }

        if (canJump && !isJumping && moveVertical > 0.1f)
        {
            rigidbody2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
            canJump = false; 

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
            Invoke("ResetJump", 2f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }

    private void ResetJump()
    {
        canJump = true;
    }
}
