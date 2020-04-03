using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundLock : MonoBehaviour
{
    public bool keyTrigger;
    public GameObject door;
    public bool doorState;
    private void Awake()
    {
        doorState = door.activeSelf;
    }
    void Update()
    {
        
        if (keyTrigger)
            door.SetActive(!doorState);
    }
}
