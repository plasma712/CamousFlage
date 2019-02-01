using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat_Start_On : MonoBehaviour
{
    public GameObject Image;

    public GameObject Text;


	// Use this for initialization
	void Start () {
        Image.gameObject.SetActive(true);
        Text.gameObject.SetActive(true);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
