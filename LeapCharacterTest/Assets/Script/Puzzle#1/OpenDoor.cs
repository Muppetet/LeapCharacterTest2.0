using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public GameObject door;

    bool isOpen = false; 

    // Update is called once per frame
    void Update()
    {
        if(!isOpen && TriggerSound.StringOn && TriggerSoundBell.BellOn && TriggerSoundTrumpet.TrumpetOn)
        {
            door.transform.position += new Vector3(4, 0, 0);
            isOpen = true; 
        }
        
    }
}
