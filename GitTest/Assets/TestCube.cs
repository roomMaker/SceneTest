using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Move());
    }
    public IEnumerator Move()
    {
        while (true)
        {
            transform.Translate(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
            yield return new WaitForSeconds(0.1f);
        }
        
    }
}
