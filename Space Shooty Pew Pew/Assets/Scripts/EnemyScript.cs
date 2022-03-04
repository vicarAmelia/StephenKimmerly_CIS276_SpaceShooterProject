using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private EnemySpawner enemySpawner;
    //When either FireShot or BigShot hits enemy it will be destroyed
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
        Destroy(gameObject);
        }
        //Calls on ScoreManager and adds points
        ScoreManager.instance.AddPoint();
        enemySpawner = FindObjectOfType<EnemySpawner>();
    }
}
