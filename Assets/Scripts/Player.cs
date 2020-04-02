﻿using System.Collections;
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

    public GameObject effect;
    public Animator camAnim;
    public GameObject gameOver;

    void Start()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    void Update()
    {
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        if (scorePoint >= 15)
        {
            SceneManager.LoadScene("LevelCompleted");
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Obstacle"))
        {
            health -= other.GetComponent<Obstacle>().damage;
            playerInventoryDisplay.updateHealthText(health);

            Destroy(other.gameObject);
            camAnim.SetTrigger("shake");
        }else if (other.CompareTag("Objective"))
        {
            scorePoint += other.GetComponent<Objective>().score;
            playerInventoryDisplay.updateScoreText(scorePoint);

            Destroy(other.gameObject);
        }
    }

}
