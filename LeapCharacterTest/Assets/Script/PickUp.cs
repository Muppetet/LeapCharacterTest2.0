using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;

    private Rigidbody rb;
    private void Awake()
    {
        theDest = GameObject.FindWithTag("PickUpDest").transform;
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        Vector3 dist = Camera.main.transform.position - this.transform.position;
        if (dist.magnitude < 3)
        {
            rb.isKinematic = true;
            rb.velocity = Vector3.zero;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("PickUpDestination").transform;
        }
        
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        rb.isKinematic = false;
    }
}
