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
        projectileVelocity = 0.5f; 
    }

    private void Update()
    {
        projectile.AddForce(new Vector2(projectileVelocity, 0), ForceMode2D.Impulse);
        
    }

}
