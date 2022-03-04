using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public GameObject FireShot;
    public GameObject BigShot;
    // Update is called once per frame
    void Update()
    {
        //Fires main weapon
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject ball;
            ball = Instantiate(FireShot, transform);

            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 70f, ForceMode.Impulse);
        }

        if(Input.GetButtonDown("Fire2"))
        {
            GameObject capsule;
            capsule = Instantiate(BigShot, transform);

            capsule.GetComponent<Rigidbody>().AddForce(Vector3.right * 70f, ForceMode.Impulse);
        }
    }
}
