using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScr : MonoBehaviour
{
    public AudioClip clip;

    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(clip);
        }
    }
}
