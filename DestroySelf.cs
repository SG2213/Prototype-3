using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    private float StartDelay = 50.5f;
    private float RepeatRate = 55.0f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Destroy", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
