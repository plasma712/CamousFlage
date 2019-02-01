using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash_One_Click_PingPong : MonoBehaviour
{
    public GameObject TrashObject1;
    public GameObject TrashObject2;
    public GameObject Rgameobject;


    void moveControl()
    {
        //this.gameObject.transform.Translate(distanceX, 0, 0);

        TrashObject1.gameObject.transform.position = new Vector3(-125.174530f, 0.0f, 0.0f); // 고정 위치로 이동 < 키포인트>
        TrashObject2.gameObject.transform.position = new Vector3(-25.174530f, -1.243636f, 0.0f); // 고정 위치로 이동 < 키포인트>
        Rgameobject.gameObject.transform.position = new Vector3(-25.174530f, -1.243636f, 0.0f); // 고정 위치로 이동 < 키포인트>


    }

    void OnMouseDown()
    {
        moveControl();
    }


}

