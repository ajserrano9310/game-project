using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float moveSpeed = 0f;
    private Rigidbody2D rb;
    private float jumpForce;
    private bool isJumping; 
    private float moveHorizontal;
    private bool facingRight = true;

    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.0f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }



    private void Start()
    {
        // This is the line of code for grabbing any coponent
        

        moveSpeed = 1.5f;
        jumpForce = 50f;
        isJumping = false;
      

    }

    void Update()
    {

        moveHorizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (rb.velocity.y < 0)
        {
            Debug.Log("Is this working??");
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        // If we are running left or right
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb.AddForce(new Vector2(moveHorizontal * moveSpeed, 0), ForceMode2D.Impulse);

        }

        if (moveHorizontal > 0 && !facingRight)
        {

            Flip();
        }

        if (moveHorizontal < 0 && facingRight)
        {

            Flip();
        }

      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
            Invoke("ResetJump", 0.25f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            isJumping = true;
        }
    }

    private void Flip()
    {

        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);

    }

    public void UpdatePlayerSpeed(float speed)
    {
        moveSpeed = speed;
    }

    public void ImproveJumping()
    {
    }
}
