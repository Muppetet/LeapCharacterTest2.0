using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioClip aC;
    public SoundLock sL;
    private void OnTriggerStay(Collider other)
    {
        if (!sL.keyTrigger)
        {
            AudioSource aS = other.gameObject.GetComponent<AudioSource>();
            if (aS.isPlaying)
                if (aS.clip == aC)
                    sL.keyTrigger = true;

        }

    }
}
