using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private Rigidbody2D projectile; 
    private float projectileVelocity; 


    void Start()
    {
        projectile = gameObject.GetComponent<Rigidbody2D>();
        projectileVelocity = 20f;
        projectile.velocity = transform.right * projectileVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            
        }
        /*
        if (collision.gameObject.TryGetComponent(out Enemy enemyComponenet))
        {
            enemyComponenet.DecreaseEnemyHealth(10f);
        }
        */
    }
}
