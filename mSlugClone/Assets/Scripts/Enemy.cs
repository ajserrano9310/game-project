using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float enemyCurrentHealth;
    private float enemyMaxHealth = 100f;
    public Projectile projectile;
    public Transform firePoint;


    public Transform player;
    const float range = 10f;  

    private void Start()
    {
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
        if(Vector2.Distance(player.position, transform.position) <= range)
        {
           
            Invoke("Shoot", 3f); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("enter range");
        }       
    }

    private void Shoot()
    {
        Projectile bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);

        Destroy(bullet, 1f); 
    }


}
