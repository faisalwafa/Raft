using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 5;
    public int scorePoint = 0;
    
    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle"))
        {
            health -= other.GetComponent<Obstacle>().damage;
            playerInventoryDisplay.updateHealthText(health);

            Destroy(other.gameObject);
        }else if (other.CompareTag("Objective"))
        {
            scorePoint += other.GetComponent<Objective>().score;
            playerInventoryDisplay.updateScoreText(scorePoint);

            Destroy(other.gameObject);
        }
    }

}
