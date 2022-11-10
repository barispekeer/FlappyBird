using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsControl : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= -3.80f)
        {
            float vertSpawn = Random.Range(-1.5f, 4.5f);
            transform.position = new Vector3(3.80f, vertSpawn, 0);
        }
        transform.Translate(-0.5f * Time.deltaTime, 0, 0);
    }
}
