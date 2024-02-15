using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 0;

    public float lifetime;

    public float lifetimeCounter;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed;

        lifetimeCounter += Time.deltaTime; 

        if (lifetimeCounter > lifetime)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Enemy"))
        {
            Destroy(this.gameObject);

        }
    }
}

