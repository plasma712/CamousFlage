using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fianl_One_Click : MonoBehaviour 
{
    public GameObject Knoker1;
    public GameObject Knoker2;
    void moveControl()
    {
        Knoker1.gameObject.transform.position = new Vector3(-18.52f, 0.430f, 1.8f);

        Knoker2.gameObject.transform.position = new Vector3(-13.74f, 4.710f, 1.0f);
    }

    void OnMouseDown()
    {
        moveControl();
    }
}
