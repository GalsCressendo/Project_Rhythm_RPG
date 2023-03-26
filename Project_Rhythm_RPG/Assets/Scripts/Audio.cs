using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Audio
{
    public string name;
    public AudioClip clip;
    public AudioSource audioSource;
    public bool playOnAwake;
    public bool loop;
}
