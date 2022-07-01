using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotEnemy : Enemy
{
    
    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(player.position, transform.position) <= Range)
        {
            Debug.Log("Player is within instance");
            timer -= Time.deltaTime;
            if (timer > 0)
            {
                Debug.Log("Not time to shoot tho");
                return;
            }
            else
            {
                Debug.Log("Shooting");
                Shoot();
                ResetTimer();
            }
        }
        else
        {
            ResetTimer();
        }
    }

    public override void Shoot()
    {
        
        Debug.Log("Shooting"); 
    }


}
