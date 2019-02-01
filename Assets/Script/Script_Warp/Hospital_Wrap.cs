using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital_Wrap : MonoBehaviour {

    public GameObject Player;
    void moveControl()
    {

        //this.gameObject.transform.Translate(distanceX, 0, 0);

        Player.gameObject.transform.position = new Vector3(17.0f, -14.50f, -35.10f); // 고정 위치로 이동 < 키포인트>
    }

    void OnMouseUp()
    {
        moveControl();

    }
}
