using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject SpawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Seonmun")
        {
            gameObject.transform.position = SpawnPoint.transform.position;
        }
    }
}
