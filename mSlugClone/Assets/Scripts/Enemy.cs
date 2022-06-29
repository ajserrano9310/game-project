using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float enemyCurrentHealth;
    private float enemyMaxHealth = 100f;
    public EnemyProjectile projectile;
    public Transform firePoint;
    private const float TimeToShoot = 5f;
    private float timer; 


    public Transform player;
    const float range = 10f;  

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
        if (Vector2.Distance(player.position, transform.position) <= range)
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

    private void Shoot()
    {
        EnemyProjectile bullet = Instantiate(projectile, firePoint.position, firePoint.rotation);
        Destroy(bullet, 0.1f); 
    }

    private void ResetTimer()
    {
        timer = TimeToShoot; 
    }


}
