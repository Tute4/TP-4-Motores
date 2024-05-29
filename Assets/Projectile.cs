using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10; 

    void Update()
    {
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        
        Enemy enemy = other.GetComponent<Enemy>();

       
        if (enemy != null)
        {
           
            enemy.TakeDamage(damage);
            
            Destroy(gameObject);
        }
    }
}
