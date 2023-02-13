using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileExplosion : MonoBehaviour
{
    public float blastRadius;
    public float explosionForce;
    public LayerMask explosionLayers;

    private Collider[] hitColliders;

    void OnCollisionEnter(Collision collision)
    {
        doExplosion(collision.contacts[0].point);
        Destroy(gameObject);
    }

    void doExplosion(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius, explosionLayers);

        foreach(Collider hitCol in hitColliders)
        {
            if(hitCol.GetComponent<Rigidbody>() != null)
            {
                hitCol.GetComponent<Rigidbody>().isKinematic = false;
                hitCol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, .02f, ForceMode.Impulse);
            }
        }
    }
}
