using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float forceAdded;
    Rigidbody rb;

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Domino")
        {
            rb.AddForce(Vector3.right * forceAdded);
        }
    }
}