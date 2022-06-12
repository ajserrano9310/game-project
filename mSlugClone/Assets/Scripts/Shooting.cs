using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject projectile; 

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
       
    }

    void Shoot()
    {
        // Shoot the projectile 
        // Instantiate the projectile before we even think about position. 

        Instantiate(projectile, transform.position, transform.rotation);
        Debug.Log("I'm shooting"); 
    }
}
