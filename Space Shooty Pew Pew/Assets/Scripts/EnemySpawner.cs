using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> enemies;
    public GameObject[] startPoints;
    GameObject currentPoint;
    int index;

    public int minNumEnemies = 0;
    public int maxNumEnemies = 1;
    public bool canSpawn;
    // Update is called once per frame
    private void Start()
    {
      Invoke("SpawnEnemy", 0.5f); 
    }

    void SpawnEnemy()
    {
        index = Random.Range(683, 702);
        currentPoint = startPoints[index];
        
        if(canSpawn)
        {
            Instantiate(enemies[Random.Range(minNumEnemies, maxNumEnemies)], currentPoint.transform.position, Quaternion.identity);
        }
    }
}
