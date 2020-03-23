using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        rb.isKinematic = true;
        //rb.useGravity = false;
        rb.velocity = Vector3.zero;
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("PickUpDestination").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}
