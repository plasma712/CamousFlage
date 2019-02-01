using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chiffonier_Key : MonoBehaviour 
{
    public GameObject Chiffonier;
    public GameObject Chiffonier0;
    public GameObject Key2;

    void moveControl()
    {
        Chiffonier0.gameObject.transform.position = new Vector3(-3.33f, 0.100f, 1.0f);

        Chiffonier.gameObject.transform.position = new Vector3(-23.7f, -15.20f, 1.0f);

        Key2.gameObject.transform.position = new Vector3(-23.7f, -15.20f, 1.0f);

    }

    void OnMouseDown()
    {
        moveControl();
    }
}
