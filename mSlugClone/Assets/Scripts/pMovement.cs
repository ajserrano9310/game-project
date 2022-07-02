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
    [Range(0, 150)] [SerializeField] private float runSpeed = 75f;

    const float PlayerSpeedIncrease = 10.0f; 

    private bool jump = true;
    private bool isDashReady = true; 

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


        if(horizontalMove > 0 || horizontalMove < 0)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                Dash(horizontalMove);
            }
           
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    public void Dash(float movementSpeed)
    {
        Debug.Log("Current speed: " + movementSpeed);
        float tempSpeed = horizontalMove * PlayerSpeedIncrease;

        controller.Move(tempSpeed, false, jump);

        Debug.Log("New speed: " + tempSpeed); 
    }
}
