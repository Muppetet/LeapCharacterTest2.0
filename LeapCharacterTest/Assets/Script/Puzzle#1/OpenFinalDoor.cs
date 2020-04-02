using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenFinalDoor : MonoBehaviour
{
    private bool isOpen = false;
    public GameObject leftDoor;
    public GameObject rightDoor; 


    void Update()
    {
        if (FinalSolution.isUnlocked && !isOpen)
        {
            leftDoor.transform.position += new Vector3(0, 0, 2);
            rightDoor.transform.position -= new Vector3(0, 0, 2);
            isOpen = true; 
        }
        else if (!FinalSolution.isUnlocked && isOpen)
        {
            leftDoor.transform.position -= new Vector3(0, 0, 2);
            rightDoor.transform.position += new Vector3(0, 0, 2);
            isOpen = false; 
        }

    }
}
