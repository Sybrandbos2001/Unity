using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    public GameObject obstacle;
    private float timeBtwSpawn;
    public float startTimeBwtSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBwtSpawn;
            if(startTimeBwtSpawn > minTime){
                startTimeBwtSpawn -= decreaseTime;
            }
        } 
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
