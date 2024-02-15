using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
   public float health = 100;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player Bullet"))
        {
            health -= 50;



        }
    }
    public void Update()
    {
       if (health <= 0)
        {
            Destroy(gameObject);
            uiManager.score += 10; 
        }
    }
}
