using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public CharacterController2D controller;
    public Player player; 
    public HealtBar staminaBar; 

    float horizontalMove = 0;
    [Range(0, 150)] [SerializeField] private float runSpeed;

    private bool jump = true;
    private bool isDashReady = true;
    private bool isDashActive = false; 

    private float timeToDash;

    private const float DashTimerCooldown = 0.1f; 
    private const float DashPercentage = 0.5f;

    void Start()
    {
        timeToDash = DashTimerCooldown; 
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        // Jumping mecanic
        if (Input.GetButtonDown("Jump")) {

            jump = true;
        }

        // Checking the dashing mechanic
        if((horizontalMove > 0 || horizontalMove < 0) && rb.velocity.y >= 0)
        {
            if (Input.GetKeyDown(KeyCode.B) && isDashReady && !isDashActive)
            {
                Dash(horizontalMove);
            }
        }

        if (isDashActive)
        {
            if (timeToDash >= 0)
            {
                timeToDash -= Time.deltaTime;
            }
            else
            {
                isDashActive = false;
                timeToDash = DashTimerCooldown; 
            }
            
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    private void Dash(float movementSpeed)
    {
        rb.velocity = Vector2.right * movementSpeed * DashPercentage;
        isDashActive = true; 
    }
}
