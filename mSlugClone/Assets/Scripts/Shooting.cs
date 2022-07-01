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
       
        Instantiate(projectile, firePoint.position, firePoint.rotation);
         
    }
}
