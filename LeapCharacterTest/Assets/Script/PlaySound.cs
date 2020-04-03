using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource otherSource;

    private void OnTriggerEnter(Collider other)
    {
        other.TryGetComponent(out otherSource);
        otherSource.Play();
    }
}
