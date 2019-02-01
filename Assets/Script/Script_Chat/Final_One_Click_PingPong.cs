using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final_One_Click_PingPong : MonoBehaviour
{
    public GameObject Knoker_1;
    public GameObject Knoker_2;

    void moveControl()
    {
        Knoker_1.gameObject.transform.position = new Vector3(-18.50f, 5.450f, 1.0f);
        Knoker_2.gameObject.transform.position = new Vector3(-20.23f, 0.820f, 0.0f);
    }

    void OnMouseDown()
    {
        moveControl();
    }

}