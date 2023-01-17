using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    public int aa=30;
    public int jum=500;
    public int speed=60;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,speed* Time.deltaTime,ForceMode.VelocityChange);
        rb.AddForce(0,-10* Time.deltaTime,0,ForceMode.VelocityChange);

        if (Input.GetKey("d"))
        {
            rb.AddForce(aa*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-aa*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        // if (Input.GetKey("w"))
        // {
        //     rb.AddForce(0,0,1000* Time.deltaTime);
        // }
        // if (Input.GetKey("s"))
        // {
        //     rb.AddForce(0,0,-1000* Time.deltaTime);
        // }

        if (Input.GetKey("space"))
        {
            if (transform.position.y<3)
            {
                rb.AddForce(0,jum* Time.deltaTime,0,ForceMode.VelocityChange);
            }
        }

    }
}
