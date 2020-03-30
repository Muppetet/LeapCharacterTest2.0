using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;
    
    private bool rbCharacterController;
    private Rigidbody rb;
    private Rigidbody prb;
    private void Awake()
    {
        theDest = GameObject.FindWithTag("PickUpDest").transform;
        rb = GetComponent<Rigidbody>();
        if (GameObject.Find("RigidBodyController"))
            rbCharacterController = true;
    }
    void OnMouseDown()
    {
        Vector3 dist = Camera.main.transform.position - this.transform.position;
        if (dist.magnitude < 5)
        {
            prb = theDest.GetComponentInParent<Rigidbody>();
            if(rbCharacterController)
                prb.mass+=rb.mass;
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
        if (rbCharacterController)
            prb.mass -= rb.mass;
    }
}
