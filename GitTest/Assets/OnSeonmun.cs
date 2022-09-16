using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSeonmun : MonoBehaviour
{
    public GameObject[] EventSeonmun;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Seonmun")
        {
            for(int i = 0; i < 3; i++)
            {
                EventSeonmun[i].SetActive(true);
            }
        }
    }
}
