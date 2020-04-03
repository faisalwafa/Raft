using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, heart4, heart5;
    public Text scoreText;

    private void Start()
    {
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
    }



    public void updateHealthIcon(int healthPoint)
    {
        if (healthPoint < 5)
        {
            switch (healthPoint)
            {
                case 4:
                    heart5.gameObject.SetActive(false);
                    break;
                case 3:
                    heart4.gameObject.SetActive(false);
                    break;
                case 2:
                    heart3.gameObject.SetActive(false);
                    break;
                case 1:
                    heart2.gameObject.SetActive(false);
                    break;
                case 0:
                    heart1.gameObject.SetActive(false);
                    break;
            }
        }
    }

    public void updateScoreText(int scorePoint)
    {
        string scoreMessage = "x " + scorePoint;
        scoreText.text = scoreMessage;
    }
}
