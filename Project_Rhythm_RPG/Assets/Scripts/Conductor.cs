using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Conductor : MonoBehaviour
{
    [SerializeField]
    private float bpm;
    private float secPerBeat;
    [SerializeField]
    private AudioManager audioManager;
    public bool useMetronome;

    private void Start()
    {
        StartCoroutine(PlayMetronome());
    }

    private IEnumerator PlayMetronome()
    {
        while (useMetronome)
        {
            yield return new WaitForSeconds(secPerBeat);
            secPerBeat = 60f / bpm;
            audioManager.Play("Metronome");
            Debug.Log("tik");
        }

    }
}
