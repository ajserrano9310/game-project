using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rb; 
    private float moveSpeed;
    private float direction; // this is to change direction after some time.
    private float walkingTime;
    private const float WalkingTime = 1f; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
        direction = 1f;
        walkingTime = 1f; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()

    {
        rb.AddForce(new Vector2(direction * moveSpeed, 0), ForceMode2D.Impulse);
        //rb.velocity = new Vector2(direction * moveSpeed*Time.deltaTime, rb.velocity.y); 
    }

    private void ChangeDirection()
    {
        direction = direction * (-1);
        walkingTime = WalkingTime; 
    }
}
