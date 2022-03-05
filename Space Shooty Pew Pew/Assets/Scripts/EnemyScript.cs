using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private EnemySpawner enemySpawner;
    //When either FireShot or BigShot hits enemy it will be destroyed
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Shot")
        {
        Destroy(gameObject);
        }
        //Calls on ScoreManager and adds points
        ScoreManager.instance.AddPoint();
        //links with Enemy Spawner script and decreases enemy count
        enemySpawner = FindObjectOfType<EnemySpawner>();
        enemySpawner.enemiesInRoom--;
        if(enemySpawner.spawnTime <= 0 && enemySpawner.enemiesInRoom <= 0)
        {
            enemySpawner.spawnerDone = true;
        }
    }
}
