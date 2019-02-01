using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;


public class Chat_One_Click : MonoBehaviour , IPointerClickHandler
{

    public GameObject Image;

    public GameObject Text;

    int k = 1;

    AudioSource audioSource;


	// Use this for initialization
	void Start () 
    {
        Image.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);

	}

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    //
    public void OnPointerClick (PointerEventData eventData)
    {
      if (k % 1 == 0)
        {
            Image.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);
            audioSource.Play();

      }
        else
        {
            Image.gameObject.SetActive(false);
            Text.gameObject.SetActive(false);
        }

        k++;
    }
 }


    //
   /* void OnMouseUp()
    {

        if (k % 1 == 0)
        {
            Image.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);

        }
        else
        {
            Image.gameObject.SetActive(false);
            Text.gameObject.SetActive(false);
        }

        k++;
    }
    }*/