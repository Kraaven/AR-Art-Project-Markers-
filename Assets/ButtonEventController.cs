using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEventController : MonoBehaviour
{
    public GameObject wolf;
    public bool PlayMusic;

    public void ini()
    {
        wolf = GameObject.FindWithTag("wolf");
        wolf.GetComponent<AudioSource>().mute = false;
    }

    public void music()
    {
        PlayMusic = !PlayMusic;
        wolf.GetComponent<AudioSource>().mute = PlayMusic;
    }

}
