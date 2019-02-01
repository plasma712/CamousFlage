using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardRobe_One_Click_PingPong : MonoBehaviour 
{

    public GameObject WardRobe1;
    public GameObject WardRobe2;
    public GameObject Rgameobject;


    void moveControl()
    {
        //this.gameObject.transform.Translate(distanceX, 0, 0);


        WardRobe1.gameObject.transform.position = new Vector3(-17.7730f, 0.914f, 8.0f); // 고정 위치로 이동 < 키포인트>
        WardRobe2.gameObject.transform.position = new Vector3(-17.7730f, 0.914f, 1.0f); // 고정 위치로 이동 < 키포인트>
        Rgameobject.gameObject.transform.position = new Vector3(-17.7730f, 0.914f, 1.0f); // 고정 위치로 이동 < 키포인트>

    }

    void OnMouseDown()
    {
        moveControl();
    }
}
