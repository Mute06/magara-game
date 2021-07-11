using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlaySoundsByOrder : MonoBehaviour
{
    [SerializeField] private AudioSource[] audioSources;
    
    public void PlayTheSounds()
    {

        StartCoroutine(Coroutine());
        
    }
    private IEnumerator Coroutine()
    {
        for (int i = 0; i < audioSources.Length; i++)
        {
            audioSources[i].Play();
            yield return new WaitForSeconds(audioSources[i].clip.length);
        }
    }
}
