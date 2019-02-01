using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Chat_One_Click_OPEN : MonoBehaviour, IPointerClickHandler
{

    public GameObject Image;

    public GameObject Text;

    int k = 1;

    // Use this for initialization
    void Start()
    {
        Image.gameObject.SetActive(false);
        Text.gameObject.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (k % 1 == 0)
        {
            Image.gameObject.SetActive(true);
            Text.gameObject.SetActive(true);

        }

    }
}
