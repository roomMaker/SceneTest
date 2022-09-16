using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public GameObject SpawnPoint;
    public GameObject Seonmun;

    private void OnTriggerEnter()
    {
        Seonmun.transform.position = SpawnPoint.transform.position;
    }
}
