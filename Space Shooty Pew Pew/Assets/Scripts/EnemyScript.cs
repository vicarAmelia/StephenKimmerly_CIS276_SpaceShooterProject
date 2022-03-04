using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private EnemySpawner enemySpawner;

    public void TakeDamage()
    {
        Destroy(gameObject);
        ScoreManager.instance.AddPoint();
        enemySpawner = FindObjectOfType<EnemySpawner>();
    }
}
