using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Enemy : MonoBehaviour 
{

    private float enemyCurrentHealth;
    private float enemyMaxHealth = 100f;
    public GameObject projectile;
    public Transform player;

    //public Transform firePoint;


    private const float TimeToShoot = 1f;
    public float timer; 


    
    public const float Range = 10f;  

    private void Start()
    {
        timer = TimeToShoot; 
        enemyCurrentHealth = enemyMaxHealth; 
    }

    public void DecreaseEnemyHealth(float damage)
    {
        if(enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }

        enemyCurrentHealth -= damage;
        Debug.Log(enemyCurrentHealth);
    }

    private void Update()
    {
      
    }

    public abstract void Shoot();
   
        
       // GameObject bullet = (GameObject)(Instantiate(projectile, firePoint.position, firePoint.rotation));
       // Destroy(bullet, 0.25f); 
    

    public void ResetTimer()
    {
        timer = TimeToShoot; 
    }


    public float GetTimeForTimer()
    {
        return TimeToShoot; 
    }

}
