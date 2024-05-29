using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = transform.right * projectileSpeed; 
        }
        else
        {
            Debug.LogError("No se pudo encontrar un Rigidbody2D en el proyectil.");
        }
    }
}
