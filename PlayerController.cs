using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.0f;

    private float jumpForce = 10.0f;
    public float gravMod;
    public bool onGround = false;

    private Rigidbody PlayerRb;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravMod;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);

        if (Input.GetKeyUp(KeyCode.Space) && onGround == true)
        {
            PlayerRb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    // Collision Triggers
    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

}
