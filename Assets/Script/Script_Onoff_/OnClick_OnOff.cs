﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnClick_OnOff : MonoBehaviour, IPointerClickHandler
{
    public GameObject On;
    public GameObject Off;

    int k = 1;

    AudioSource audioSource;


    void start()
    {

    }
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        k++;
        if (k % 2 == 0)
        {
            On.gameObject.SetActive(false);
            Off.gameObject.SetActive(true);
            audioSource.Play();

        }
        else
        {
            On.gameObject.SetActive(true);
            Off.gameObject.SetActive(false);
            audioSource.Play();

        }

    }
}
