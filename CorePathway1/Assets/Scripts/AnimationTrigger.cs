using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animController;

    void onTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ball")) 
        {
            animController.SetTrigger("MovePlatform");
        }
    }
}