using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text healthText;

    public Text scoreText;

    public void updateHealthText(int healthPoint)
    {
        string healthMessage = "Health = " + healthPoint;
        healthText.text = healthMessage;
    }

    public void updateScoreText(int scorePoint){
        string scoreMessage = "Score = " + scorePoint;
        scoreText.text = scoreMessage;
    }
}
