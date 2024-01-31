using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_SpawnManager : MonoBehaviour
{
    public GameObject BG;

    private float StartDelay = 0.0f;
    private float RepeatRate = 24.75f;
    private bool SpawningBG = true;

    private Vector3 SpawnPos;
    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
       
        InvokeRepeating("SpawnBG", StartDelay, RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == true)
        {
            SpawningBG = false;
        }
    }

    void SpawnBG()
    {
        SpawnPos = transform.position;

        if (SpawningBG == true)
        {
            Instantiate(BG, SpawnPos, BG.transform.rotation);
        }
    }
}