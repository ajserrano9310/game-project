using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float enemyCurrentHealth;
    private float enemyMaxHealth = 100f;

    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth; 
    }

    public void DecreaseEnemyHealth(float damage)
    {
        if(enemyCurrentHealth <= 0)
        {
            Destroy(this);
        }

        enemyCurrentHealth -= damage;
        Debug.Log(enemyCurrentHealth);
    }

    private void Update()
    {
        
    }


}
