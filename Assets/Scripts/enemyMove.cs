using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    public float horizontalSpeed = 2f; 
    public float stopPointX = 0f; 
    public float verticalSpeed = 2f; 
    public float verticalRange = 2f; 

    private bool isMovingHorizontally = true;
    private bool isMovingUp = true;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isMovingHorizontally)
        {
            
            Vector3 newPosition = transform.position + Vector3.left * horizontalSpeed * Time.deltaTime;

            
            transform.position = newPosition;

            
            if (transform.position.x <= stopPointX)
            {
                isMovingHorizontally = false;
            }
        }
        else
        {
            
            float newYPosition = transform.position.y + (isMovingUp ? verticalSpeed : -verticalSpeed) * Time.deltaTime;

            
            transform.position = new Vector3(transform.position.x, newYPosition, transform.position.z);

            
            if (Mathf.Abs(transform.position.y - initialPosition.y) >= verticalRange)
            {
                isMovingUp = !isMovingUp;
            }
        }
    }
}

