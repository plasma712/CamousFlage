using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardRobe_Clothes_Click_NoItem : MonoBehaviour
{
    public GameObject Image;

    public GameObject Text;

    int k = 1;
	// Use this for initialization

	void Start () 
    {
        Image.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
	}

    void OnMouseUp()
    {

        if (k % 1 == 0)
        {
            Image.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);

        }
        else
        {
            Image.gameObject.SetActive(false);
            Text.gameObject.SetActive(false);
        }

        k++;
    }


}
