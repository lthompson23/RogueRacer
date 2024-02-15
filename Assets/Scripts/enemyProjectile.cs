using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyProjectile : MonoBehaviour
{
    public float speed = 0;

    public float lifetime;

    public float lifetimeCounter;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Time.deltaTime * speed;

        lifetimeCounter += Time.deltaTime;

        if (lifetimeCounter > lifetime)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }


}
