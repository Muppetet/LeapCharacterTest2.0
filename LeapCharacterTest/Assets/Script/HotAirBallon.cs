using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotAirBallon : MonoBehaviour
{
    public Rigidbody rb;
    public float forceAmount;
    public ForceMode forceMode;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rb.AddForce(forceAmount * Vector3.up * Time.deltaTime, forceMode);
        }
        
    }
}
