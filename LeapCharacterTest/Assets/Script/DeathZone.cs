using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.CompareTag("Player"))
            other.gameObject.transform.SetPositionAndRotation(new Vector3(0, 2, 0), Quaternion.identity);
    }
}
