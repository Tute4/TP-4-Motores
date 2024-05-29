using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float scrollSpeed = 1f;
    public float resetPosition = 10f;
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        
        if (transform.position.x < startPosition.x - resetPosition)
        {
            transform.position = startPosition;
        }
    }
}
