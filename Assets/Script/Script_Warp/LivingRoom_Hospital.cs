﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoom_Hospital : MonoBehaviour {

    public GameObject Player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void moveControl()
    {

        //this.gameObject.transform.Translate(distanceX, 0, 0);

        Player.gameObject.transform.position = new Vector3(0.0f, -15.0f, -35.10f); // 고정 위치로 이동 < 키포인트>
    }

    void OnMouseUp()
    {
        moveControl();
    }
}
