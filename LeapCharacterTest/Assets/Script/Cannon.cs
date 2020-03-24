using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    public float shootingForce;
    public ForceMode forceMode;

    float cd = 3, time;

    void Update()
    {
        time += Time.deltaTime;
        if (time > cd)
        {
            GameObject bull = Instantiate(bullet, firepoint.position, Quaternion.identity);
            bull.GetComponent<Rigidbody>().AddForce(shootingForce * this.transform.forward, forceMode);
            time = 0;
        }   
    }
}
