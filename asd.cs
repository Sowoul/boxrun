using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asd : MonoBehaviour
{
    public float forwardForce = 300f;
    public float sidewaysForce = 200f;
    private Vector2 lastPosition;    
    public Rigidbody rb;
    void Update()
    {
    rb.AddForce(0, 0, forwardForce * Time.deltaTime);

    if(Input.touchCount == 1)
    {
        Touch touch = Input.GetTouch(0);
        if(touch.phase == TouchPhase.Began)
        {
            lastPosition = touch.position;
        }
        if(touch.phase == TouchPhase.Moved)
        {
                // get the moved direction compared to the initial touch position
            var direction = touch.position - lastPosition ;

                // get the signed x direction
                // if(direction.x >= 0) 1 else -1
            var signedDirection = Mathf.Sign(direction.x);
            rb.AddForce(signedDirection*sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
            if (direction.x*Mathf.Sign(direction.x)>Mathf.Sign(direction.y)*direction.y){
                rb.AddForce(signedDirection*sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
            }
            else if (direction.x*Mathf.Sign(direction.x)<Mathf.Sign(direction.y)*direction.y) {
                if (transform.position.y<3)
                {
                    rb.AddForce(0,500* Time.deltaTime,0,ForceMode.VelocityChange);
                }

            }
        }
    }
    }
}

