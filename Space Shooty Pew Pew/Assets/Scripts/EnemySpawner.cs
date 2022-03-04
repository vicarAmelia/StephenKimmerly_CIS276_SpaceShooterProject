using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> enemies;
    public GameObject[] startPoints;
    GameObject currentPoint;
    int index;

    public float minNumEnemies = 0;
    public float maxNumEnemies = 1;
    // Update is called once per frame
    private void Start()
    {
      Invoke("SpawnEnemy", 0.5f); 
    }

    void SpawnEnemy()
    {
        index = Random.Range(683f, 702f);
        currentPoint = startPoints[index];
        Instantiate(enemies[Random.Range(minNumEnemies,maxNumEnemies)]);
    }
}
