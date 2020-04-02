using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material greenMaterial;
    public Material redMaterial;


    void Update()
    {
        if (FinalSolution.isUnlocked)
        {
            transform.GetComponent<Renderer>().material = greenMaterial;
        }
        else
            transform.GetComponent<Renderer>().material = redMaterial;
    }
}
