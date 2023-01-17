using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    public NewBehaviourScript nb;
    void OnCollisionEnter(Collision other) {
        if (other.collider.tag == "obstacle"){
            nb.enabled = false;
        }
    }
}
