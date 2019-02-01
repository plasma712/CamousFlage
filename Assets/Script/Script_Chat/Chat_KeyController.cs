using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat_KeyController : MonoBehaviour
{
    
    public GameObject Unmet;
    public GameObject met;

    int k = 0;
    int n = 0;

    void moveControl()
    {
        //Unmet.gameObject.transform.Translate(0, 0, 0.0660f);
      //  met.gameObject.transform.Translate(0, 0, -0.0660f);

        Unmet.gameObject.transform.Translate(0, 0, 0.16667f);
        met.gameObject.transform.Translate(0, 0, -0.16667f);

    }

    void OnMouseDown()
    {
        if (k==0 && n==0)
        { 
            moveControl();
            k++;
        }

    }
     
}

