using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_One_Click_PingPong : MonoBehaviour {

    public GameObject Bag1;
    public GameObject Bag2;
    public GameObject Rgameobject;


    void moveControl()
    {
        //this.gameObject.transform.Translate(distanceX, 0, 0);

        Bag1.gameObject.transform.position = new Vector3(-23.240f, 4.0f, 8.0f); // 고정 위치로 이동 < 키포인트>
        Bag2.gameObject.transform.position = new Vector3(-23.240f, -0.77f, 4.0f); // 고정 위치로 이동 < 키포인트>
        Rgameobject.gameObject.transform.position = new Vector3(-23.240f, -0.77f, 4.0f); // 고정 위치로 이동 < 키포인트>

    }

    void OnMouseDown()
    {
        moveControl();
    }
}
