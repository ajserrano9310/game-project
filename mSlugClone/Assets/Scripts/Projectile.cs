using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D projectile;
    private float projectileVelocity;

    private void Start()
    {
        projectile = gameObject.GetComponent<Rigidbody2D>();
        projectileVelocity = 20f;
        projectile.velocity = transform.right * projectileVelocity; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.TryGetComponent(out Enemy enemyComponenet))
        {
            enemyComponenet.DecreaseEnemyHealth(10f); 
        }
    }

}

