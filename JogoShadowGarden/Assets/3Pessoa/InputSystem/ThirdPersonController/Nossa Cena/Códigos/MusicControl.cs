using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControl : MonoBehaviour
{
    public AudioMixerSnapshot outOfCombat, inCombat;
    public AudioSource[] audios;

    public float transitionIn, transitionOut;

    private bool inCombatBool = false;

    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponentsInChildren<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerOn"))
        {
            print("Bati");
            inCombatBool = true;
            audios[1].Play();
            inCombat.TransitionTo(transitionIn);
        }
        if (other.CompareTag("TriggerOff"))
        {
            print("Bati Também");
            inCombatBool = false;
            audios[0].Play();
            outOfCombat.TransitionTo(transitionOut);
        }
    }
}
