﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.Source = gameObject.AddComponent<AudioSource>();
            s.Source.clip = s.Clip;
            s.Source.volume = s.Volume;
            s.Source.pitch = s.Pitch;
            s.Source.loop = s.Loop;
        }
    }

    private void Start()
    {
        PlaySound("Ambient");
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);

        if (!s.Source.isPlaying)
        {
            s.Source.Play();
        }
        
    }

    public void ForceStop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.Name == name);

        if (s.Source.isPlaying)
        {
            s.Source.Stop();
        }
    }
}