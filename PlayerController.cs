using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 0.0f;
    private float jumpForce = 10.0f;
    private float gravMod = 1.0f;

    private Rigidbody PlayerRb;

    public bool onGround = false;
    public bool gameOver = false;
    public bool gameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();

        Physics.gravity *= gravMod;

        if (gameOver == true)
        {
            Debug.Log("You poor fool! You were supposed to avoid the painful obstacles!");
        } 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);

        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            PlayerRb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
            onGround = false;
        }
    }

    // Collision Triggers
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
        onGround = true;
        }
       
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
        }
    }

}
