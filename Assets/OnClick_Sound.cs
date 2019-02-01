using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick_Sound : MonoBehaviour
{
    AudioSource audioSource;
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseUp()
    {
        //audioSource.Play();
        audioSource.Pause();

    }
}