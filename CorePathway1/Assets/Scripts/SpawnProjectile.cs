using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float propulsionForce;

    private Transform myTransform;

    void Start()
    {
        setInitialReferences();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            summonProjectile();
        }
    }

    void summonProjectile()
    {
        GameObject projectile = (GameObject)Instantiate(projectilePrefab, myTransform.transform.TransformPoint(0, 0, 2f), myTransform.rotation);
        projectile.GetComponent<Rigidbody>().AddForce(myTransform.up * propulsionForce, ForceMode.Impulse);
        Destroy(projectile, 3);
    }

    void setInitialReferences()
    {

    }
}
