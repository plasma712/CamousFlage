using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Image;
    public GameObject Text;

    int k = 1;

    void Start()
    {
        Image.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
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
    }
}
