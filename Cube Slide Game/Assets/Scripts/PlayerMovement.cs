using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float sidewaysForce = 1300f;
    public float maxSpeed = 70f;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        Debug.Log(rb.velocity.z);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") && Input.GetKey("b") == true)
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        }

        else 
        {
            rb.velocity = new Vector3(0, rb.velocity.y, rb.velocity.z);
        } 
    }

    private void Update()
    {
        if (rb.velocity.z > maxSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 70);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}