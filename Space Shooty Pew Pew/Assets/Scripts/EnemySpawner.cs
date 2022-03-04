using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyShip;

    // Update is called once per frame
    void Update()
    {
        GameObject enemy; 
        enemy = Instantiate(EnemyShip, transform);
        Instantiate(EnemyShip[Random.Range(0,1)]);
        enemy.GetComponent<Rigidbody>().AddForce(Vector3.down * 5f);
    }
}
