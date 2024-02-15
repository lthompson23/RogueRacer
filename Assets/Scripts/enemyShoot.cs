
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class enemyShoot : MonoBehaviour
{

    public GameObject bullet;

    public UnityEngine.Transform Offset;

    float timeBtwShots;

    public projectile ProjectilePrefab;

    public float startTimeBtwShots;
    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(bullet, Offset.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        
    }

    
}



    

