﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV_TV_People : MonoBehaviour {

    public GameObject Player;
    void moveControl()
    {

        //this.gameObject.transform.Translate(distanceX, 0, 0);

        Player.gameObject.transform.position = new Vector3(50.0f, -40.0f, -35.10f); // 고정 위치로 이동 < 키포인트>
    }

    void OnMouseUp()
    {
        moveControl();

    }
}
