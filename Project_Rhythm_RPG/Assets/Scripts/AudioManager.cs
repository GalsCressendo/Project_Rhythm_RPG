using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<Audio> audios;

    private void Awake()
    {
        foreach(Audio a in audios)
        {
            a.audioSource = gameObject.AddComponent<AudioSource>();

            a.audioSource.clip = a.clip;
            a.audioSource.playOnAwake = a.playOnAwake;
            a.audioSource.loop = a.loop;
        }
    }

    public float Play(string name)
    {
        foreach(Audio a in audios)
        {
            if(a.name == name)
            {
                a.audioSource.Play();
                return a.audioSource.clip.length;
            }
        }

        return 0;
    }
}
