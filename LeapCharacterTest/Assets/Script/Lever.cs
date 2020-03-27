using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public string tag;
    public GameObject spawnObject;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag))
        {
            Instantiate(spawnObject, spawnPoint.position, Quaternion.identity);
        }
    }
}
