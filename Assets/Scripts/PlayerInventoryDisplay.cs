using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text healthText;

    public void updateHealthText(int healthPoint)
    {
        string healthMessage = "Health = " + healthPoint;
        healthText.text = healthMessage;
    }
}
