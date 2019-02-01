using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Click_Item_Bye : MonoBehaviour
{

    public GameObject Item;

    public GameObject ItemChang;
    int k = 1;

    void OnMouseUp()
    {

        if (k % 1 == 0)
        {
            Item.gameObject.SetActive(false);
            ItemChang.gameObject.SetActive(false);

        }
        else
        {
            Item.gameObject.SetActive(false);
            ItemChang.gameObject.SetActive(false);
        }

        k++;
    }


}
