using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public AudioClip hitSound;
    
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Candy"))
        {
            Score.instance.Points -= 10;
            audioSource.PlayOneShot(hitSound);
        }
        Destroy(other.gameObject);
    }
}
