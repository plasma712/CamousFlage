using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Click_Play : MonoBehaviour {

    AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseUp()
    {
        audioSource.Play();
        //audioSource.Pause();

    }
}
