using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public AudioMixerGroup mixer;
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = mixer;
            s.source.playOnAwake = s.playOnAwake;
            if (s.playOnAwake)
            {
                s.source.Play();
            }

        }
    }

    public void PlaySound(string _name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == _name);
        if (s == null)
        {
            Debug.LogWarning(_name + "isimli bir ses bulunamadý");
            return;
        }
        s.source.Play();
    }

    public void StopSound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning(name + "isimli bir ses bulunamadý");
            return;
        }
        s.source.Play();
    }
    public void StopAll()
    {
        foreach (Sound s in sounds)
        {
            if (s.source.isPlaying)
            {
                s.source.Stop();
            }
        }
    }

    public float GetClipLength(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning(name + "isimli bir ses bulunamadý");
            return 0;
        }
        return s.source.clip.length;
    }

    public IEnumerator PlaySoundsInOrder(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            PlaySound(names[i]);
            Debug.Log("Playyed Sound");
            yield return new WaitForSeconds(GetClipLength(names[i]));
        }
    }

}