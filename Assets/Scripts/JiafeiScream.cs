using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiafeiScream : MonoBehaviour
{
    public string Player; // The tag to check for collision
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.CompareTag(Player))
        {
            audioSource.Play();
        }
    }
}
