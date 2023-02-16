using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    Rigidbody rb;
    public float forceAdded;

    void OnCollisionEnter(Collider col)
    {
        if (Rigidbody.OnCollisionEnter(Collision))
        {
            
        }
    }
}