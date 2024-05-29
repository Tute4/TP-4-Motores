using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * moveSpeed * Time.deltaTime;

        
        GetComponent<Rigidbody2D>().MovePosition((Vector2)transform.position + movement);
    }
}
