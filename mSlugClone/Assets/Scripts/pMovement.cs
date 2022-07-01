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

    const float basePlayerSpeed = 75f;

    [Range(0, 100)] [SerializeField] private float runSpeed = 75f; 


    private bool jump = true; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump")) {

            jump = true;
        }


        if (Input.GetButton("Fire2") && staminaBar.CanSprint && (staminaBar.GetCurrentStamina() > 0) && !staminaBar.IsSprinting)
        {

         
        }
        else
        {
            if (staminaBar.NeedsToRegenerate)
            {
            
            }
           
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Dash()
    {

    }
}
