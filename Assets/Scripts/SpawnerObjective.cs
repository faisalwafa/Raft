using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerObjective : MonoBehaviour
{
    public GameObject[] objectivePatterns;
    private float timeBtwnSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    // Update is called once per frame
    void Update()
    {
        if (timeBtwnSpawn <= 0)
        {
            int rand = Random.Range(0, objectivePatterns.Length);

            Instantiate(objectivePatterns[rand], transform.position, Quaternion.identity);
            timeBtwnSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwnSpawn -= Time.deltaTime;
        }
    }
}
