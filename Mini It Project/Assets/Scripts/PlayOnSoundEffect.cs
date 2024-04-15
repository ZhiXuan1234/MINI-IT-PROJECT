using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnSoundEffect : MonoBehaviour
{
    AudioSource source;
    Collider2D soundTrigger;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        soundTrigger = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            source.Play();
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //source.Play();
    }
}
