using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    float currentTime;

    //Score
    int score;
    public Text scoreText;
    public float multiplier = 5;

    private Health playerHealth;

    private void Start()
    {
        currentTime = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerHealth = player.GetComponent<Health>();
        }
    }

    private void Update()
    {
        if (playerHealth != null && playerHealth.currentHealth > 0)
        {
            currentTime += Time.deltaTime * multiplier;
        }

        score = Mathf.RoundToInt(currentTime);
        // DIsplay the current time with 1 decimal point
        scoreText.text = currentTime.ToString("F1");

    }



} //class
