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

    private void Update()
    {
        //projectile.AddForce(new Vector2(projectileVelocity, 0), ForceMode2D.Impulse);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("Collided with enemy");
            Destroy(projectile);
        }
    }

}
