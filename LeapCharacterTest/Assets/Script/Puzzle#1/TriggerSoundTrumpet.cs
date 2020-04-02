using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundTrumpet : MonoBehaviour
{
    public AudioClip triggerSound;
    AudioSource audioSource;
    public static bool TrumpetOn = false;
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
            TrumpetOn = true;
        }
    }
}
