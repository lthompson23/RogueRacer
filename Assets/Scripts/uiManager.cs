using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Text scoreText;

    public static int score = 0;

    public Text healthText; 

    public static int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
        score = 0;
    }

    public void UpdateHealth()
    {
        healthText.text = "Health " + playerHealth.health; 
    }

    public void UpdateScore()
    {
        scoreText.text = "Score " + score;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateScore();

        UpdateHealth();
    }

}