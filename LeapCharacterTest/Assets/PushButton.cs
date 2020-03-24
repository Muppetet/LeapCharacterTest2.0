using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public Transform buttonStart;
    public Transform button;
    public Transform spawnPoint;
    public GameObject block;
    bool buttonPressed;


    void OnTriggerEnter(Collider other)
    {
        buttonPressed = true;
        SpawnBlock();
    }

    private void SpawnBlock()
    {
        Instantiate(block, spawnPoint.position, Quaternion.identity);
    }

    private void Update()
    {
        if (buttonPressed)
        {
            if (button.localPosition.z < buttonStart.localPosition.z)
            {
                Debug.Log("Test");
            }
                
        }

    }
}
