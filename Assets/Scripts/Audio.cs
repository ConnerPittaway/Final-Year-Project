using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Audio : MonoBehaviour
{
    public static Audio Instance;
    public Sounds[] musicSound, sfxSounds;
    public AudioSource backgroundSource, sfxSource;
    public string currentlyPlaying;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        Debug.Log("Start");
        //PlayMusic("Background Music Track 1");
    }

    public void BackgroundChangeVolume(float value)
    {
        backgroundSource.volume = value;
    }

    public void SoundEffectsChangeVolume(float value)
    {
        sfxSource.volume = value;
    }

    public void PlayMusic(string name)
    {
        Sounds s = Array.Find(musicSound, x => x.soundName == name);

        if (s == null)
        {
            Debug.Log("No Sound Found");
        }
        else
        {
            backgroundSource.clip = s.audioClip;
            backgroundSource.Play();
            currentlyPlaying = name;
        }
    }

    public void PlaySFX(string name)
    {
        Sounds s = Array.Find(sfxSounds, x => x.soundName == name);

        if (s == null)
        {
            Debug.Log("No Sound Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.audioClip);
        }
    }
}
