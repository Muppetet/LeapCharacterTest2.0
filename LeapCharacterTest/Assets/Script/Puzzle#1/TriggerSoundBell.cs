using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundBell : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;
    public static bool BellOn = false; 
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerSound != null)
        {
            audioSource.PlayOneShot(triggerSound, 0.7F);
            BellOn = true; 
        }
    }
}
