using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxStamina;
    public HealtBar healt;
    private Movement movement; 

    private float playerSpeed;

    public float PlayerSpeed { get => playerSpeed; set => playerSpeed = value; }

    private void Start()
    {
        movement = gameObject.GetComponent<Movement>();
        playerSpeed = 0.75f;
    }

    private void Update()
    {
        
        if (Input.GetButton("Fire2") && healt.CanSprint && (healt.GetCurrentStamina() > 0) )
        {
            healt.IsSprinting = true; 
            healt.Sprint();
            movement.UpdatePlayerSpeed(playerSpeed * 1.25f);
        }
        else
        {
            healt.IsSprinting = false;
            healt.RegenerateStamina();
            movement.UpdatePlayerSpeed(playerSpeed);
        }

        
        
    }


}
