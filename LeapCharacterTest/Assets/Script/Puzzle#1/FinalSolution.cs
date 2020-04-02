using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSolution : MonoBehaviour
{
    public Material greenMaterial;
    public Material redMaterial;
    public static bool isUnlocked = false; 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "CubeKey")
        {
            transform.GetComponent<Renderer>().material = greenMaterial;
            isUnlocked = true; 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "CubeKey")
        {
            transform.GetComponent<Renderer>().material = redMaterial;
            isUnlocked = false; 
        }
    }
}
