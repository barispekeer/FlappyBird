using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    //yatay 3.9f_-3.9f dikey -0.6f_-1.85f
    void Start()
    {
        float vertSpawn = Random.Range(-0.6f, -1.85f);
        transform.position = new Vector3(3.90f, vertSpawn, 0);
    }

    
    void Update()
    {
        if (transform.position.x <= -3.9f)
        {
            Destroy(gameObject);
        }
        transform.Translate(-1.5f * Time.deltaTime, 0, 0);
    }
}
