using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject pipe;
    void Start()
    {
        InvokeRepeating("AddPipe", 0, 3f);
    }

    
    void Update()
    {
        
    }
    void AddPipe()
    {
        Instantiate(pipe);
    }
}
