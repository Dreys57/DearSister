using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    [SerializeField] private string name;
    
    [SerializeField] private AudioClip clip;
    
    [Range(0f, 1f)]
    [SerializeField] private float volume;
    
    [Range(0.1f, 3f)]
    [SerializeField] private float pitch;

    [SerializeField] private bool loop;

    [HideInInspector]
    [SerializeField] private AudioSource source;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public AudioClip Clip
    {
        get => clip;
        set => clip = value;
    }

    public float Volume
    {
        get => volume;
        set => volume = value;
    }

    public float Pitch
    {
        get => pitch;
        set => pitch = value;
    }
    
    public bool Loop
    {
        get => loop;
        set => loop = value;
    }

    public AudioSource Source
    {
        get => source;
        set => source = value;
    }
}
