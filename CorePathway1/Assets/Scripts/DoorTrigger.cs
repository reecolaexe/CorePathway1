using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            anim.SetTrigger("OpenDoor");
        }
    }
}