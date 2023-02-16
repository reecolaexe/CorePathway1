using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    Rigidbody rb;
    public float forceAdded;
    private Collider[] hitColliders;

    void OnCollisionEnter(Collision col)
    {
        foreach (Collider hitCol in hitColliders)
        {
            if (hitCol.GetComponent<Rigidbody>() != null)
            {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddForce(transform.forward * forceAdded);
            }
        }
    }
}