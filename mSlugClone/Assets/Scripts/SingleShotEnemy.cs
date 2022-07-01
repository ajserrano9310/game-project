using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotEnemy : Enemy
{


    private Transform firePoint;

    public GameObject projectile;

    private void Start()
    {
        firePoint = transform.Find("EnemyFirepoint"); 

        if(firePoint == null)
        {
            Debug.Log("This shit was null"); 
        }
        else
        {
            Debug.Log("The name of the required object is:" + firePoint.name);
        }
    }

    void Update()
    {
        if (Vector2.Distance(player.position, transform.position) <= Range)
        {
            timer -= Time.deltaTime;

            if (timer > 0)
            {
                return;
            }
            else
            {
                Shoot();
                ResetTimer();
            }
        }

        else
        {
            if(timer < GetTimeForTimer())
            {
                ResetTimer();
            }
            
        }
    }
    public override void Shoot()
    {

         GameObject bullet = (GameObject)(Instantiate(projectile, firePoint.position, firePoint.rotation));
         Destroy(bullet, 0.25f); 
    }


}
