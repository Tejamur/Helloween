using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public End end;
    public float speed = 15;
    public AudioClip hitSound;
    
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        
        transform.Translate(x, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Candy"))
        {
            Destroy(other.gameObject);
            audioSource.PlayOneShot(hitSound);
            Score.instance.Points += 10;
        }
        else if (other.gameObject.CompareTag("Poison"))
        {
            end.EndScene();
        }
    }
}
