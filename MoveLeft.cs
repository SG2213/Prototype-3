using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5.0f;

    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
        }
        else
        {

        }
    }
}
