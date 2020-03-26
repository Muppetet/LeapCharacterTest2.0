using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyButton : MonoBehaviour
{
    public string tag;

    public Transform spawnPoint;
    public GameObject spawnItem;

    GameObject spawnedGO;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag) && spawnedGO == null)
        {
            spawnedGO = Instantiate(spawnItem, spawnPoint.position, Quaternion.identity);
        } else if (other.CompareTag(tag))
        {
            spawnedGO.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tag))
        {
            spawnedGO.SetActive(false);
        }
    }
}
