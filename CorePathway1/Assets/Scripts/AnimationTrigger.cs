using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animController;
    public string objectTag;
    public string animTrigger;

    void onTriggerEnter(Collider other)
    {
        if(other.CompareTag(objectTag)) 
        {
            animController.SetTrigger(animTrigger);
        }
    }
}