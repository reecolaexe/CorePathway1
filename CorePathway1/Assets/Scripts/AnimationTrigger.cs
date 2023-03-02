using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator anim;
    public bool played = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision col)
    {
        if(!played)
        {
            if(col.gameObject.name == "Sphere")
            {
                anim.Play("PlatformMove7");
                played = true;
            }
        }
    }
}