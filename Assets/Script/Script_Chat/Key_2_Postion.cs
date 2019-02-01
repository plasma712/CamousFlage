using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_2_Postion : MonoBehaviour 
{

    public GameObject Chiffonier;

    void moveControl()
    {
        Chiffonier.gameObject.transform.position = new Vector3(-23.67f, -15.140f, 1.0f);

    }

    void OnMouseDown()
    {
        moveControl();
    }

}
