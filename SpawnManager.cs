using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ObsPre;

    private float StartDelay = 1.5f;
    private float RepeatRate = 3.2f;
    private bool SpawnObs = true;

    private Vector3 SpawnPos;
    public PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        
        InvokeRepeating("SpawnObstacle", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == true)
        {
            SpawnObs = false;
        }
    }

    void SpawnObstacle ()
    {
        SpawnPos = transform.position;

        if (SpawnObs == true)
        {
            Instantiate(ObsPre[0], SpawnPos, ObsPre[0].transform.rotation);
        }
    }
}
