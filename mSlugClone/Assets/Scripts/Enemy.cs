using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Enemy : MonoBehaviour 
{

    private float enemyCurrentHealth;
    private const float EnemyMaxHealth = 100f;
    public Transform player;

    private const float TimeToShoot = 1f;
    public float timer; 
    
    public const float Range = 10f;

    #region Abstract Methods
    public abstract void Shoot();
    #endregion

    private void Start()
    {
        timer = TimeToShoot; 
        enemyCurrentHealth = EnemyMaxHealth; 
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

    public void ResetTimer()
    {
        timer = TimeToShoot; 
    }


    public float GetTimeForTimer()
    {
        return TimeToShoot; 
    }


}
