using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject projectile;
    public Transform firePoint; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
       
    }

    void Shoot()
    {
        // Shoot the projectile 
        // Instantiate the projectile before we even think about position. 

        Instantiate(projectile, firePoint.position, firePoint.rotation);
        Debug.Log("I am shooting bullets");
         
    }
}
