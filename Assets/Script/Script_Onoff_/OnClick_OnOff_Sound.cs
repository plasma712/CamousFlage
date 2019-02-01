using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick_OnOff_Sound : MonoBehaviour {

    public GameObject On;
    void start()
    {
        On.gameObject.SetActive(false);

    }

    void OnMouseUp()
    {
        On.gameObject.SetActive(true);
    }

}
