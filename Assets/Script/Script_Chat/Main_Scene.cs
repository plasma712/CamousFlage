using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Scene : MonoBehaviour 
{
    public int Num;
    public GameObject Orgin;
    public GameObject Click;
    

	// Use this for initialization
	void Start () 
    {
        Orgin.gameObject.SetActive(true);
        Click.gameObject.SetActive(false);
        Screen.SetResolution(1080, 720, true); 
	}

	void OnMouseEnter()
    {
        Orgin.gameObject.SetActive(false);
        Click.gameObject.SetActive(true);

    }

    void OnMouseExit()
    {
        Orgin.gameObject.SetActive(true);
        Click.gameObject.SetActive(false);
    }
}
