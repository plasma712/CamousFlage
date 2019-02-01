using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chat_Two_Click_1 : MonoBehaviour, IPointerClickHandler

{

    public GameObject Image;
    public GameObject Test;

    int k = 1;

    AudioSource audioSource;


    // Use this for initialization
    void Start()
    {
        Image.gameObject.SetActive(false);
        Test.gameObject.SetActive(false);

    }

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {

        if (k % 2 == 1)
        {
            Image.gameObject.SetActive(true);
            Test.gameObject.SetActive(true);
            audioSource.Play();

        }
        else
        {
            Image.gameObject.SetActive(false);
            Test.gameObject.SetActive(false);

        }

        k++;
    }
}
