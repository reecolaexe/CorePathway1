using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSound : MonoBehaviour
{
    public AudioSource triggerSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            triggerSound.Play();
        }
    }
}