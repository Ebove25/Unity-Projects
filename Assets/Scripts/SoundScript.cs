using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    //The sounds that will when when an objects enters this trigger
    public AudioClip triggersound;
    //The audio source that will play that sound
    public AudioSource source;
    private AudioClip triggerSound;

    private void OnTriggerEnter(Collider other)
    {
        //Tell the source to play sound triggerSound once
        source.PlayOneShot(triggerSound);
    }
}
