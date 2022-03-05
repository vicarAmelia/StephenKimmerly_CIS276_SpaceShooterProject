using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] startPoints;
    GameObject currentPoint;
    int index;

    public GameObject[] enemies;
    public float minTimeForSpawns;
    public float maxTimeForSpawns;
    public bool canSpawn;
    public float spawnTime;
    public int enemiesInRoom;
    // Update is called once per frame
    private void Start()
    {
      Invoke("SpawnEnemy", 0.5f); 
    }
    //Spawns Enemys into designated spawn points
    void SpawnEnemy()
    {
        index = Random.Range(0, startPoints.Length);
        currentPoint = startPoints[index];
        float timeForSpawns = Random.Range(minTimeForSpawns, maxTimeForSpawns);
        
        if(canSpawn)
        {
            Instantiate(enemies[Random.Range(0, enemies.Length)], currentPoint.transform.position, Quaternion.identity);
            enemiesInRoom++;
        }
        Invoke("SpawnEnemy", timeForSpawns);
    }
}
