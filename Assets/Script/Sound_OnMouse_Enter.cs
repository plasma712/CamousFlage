using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_OnMouse_Enter : MonoBehaviour 
{

    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseEnter()
    {
        audioSource.Play();

    }
}
