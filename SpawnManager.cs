using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float StartDelay = 1.5f;
    private float RepeatRate = 3.0f;

    public GameObject ObsPF;
    private Vector3 SpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPos = transform.position;
        InvokeRepeating("SpawnObstacle", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle ()
    {
        Instantiate(ObsPF, SpawnPos, ObsPF.transform.rotation);
    }
}
