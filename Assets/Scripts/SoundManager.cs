using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    BIRD,
    PLANE,
    CITY,
    THUD,
    WOOSH,
    WIND,
    SUCCESS,
    FAIL,
    CRASH,
    CLOCK,
    INTRO,
    RELOAD

}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioClip[] soundList;
    private static SoundManager instance;
    private AudioSource audioSource; //one shot sounds
    private AudioSource[] audioSourcesLooping; //

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSourcesLooping = GetComponents<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1)
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }

    public static void PlayLoopingSound(SoundType sound, float volume = 1, int sourceIndex = 0)
    {
        if (instance.audioSourcesLooping.Length > sourceIndex)
        {
            instance.audioSourcesLooping[sourceIndex].clip = instance.soundList[(int)sound];
            instance.audioSourcesLooping[sourceIndex].loop = true;
            instance.audioSourcesLooping[sourceIndex].volume = volume;
            instance.audioSourcesLooping[sourceIndex].Play();
        }
        else
        {
            Debug.LogError("AudioSource index out of bounds.");
        }

    }

    public static void StopLoopingSound()
    {
        instance.audioSource.Stop();
        instance.audioSource.loop = false;
    }

    //EXAMPLE USAGE: SoundManager.PlaySound(SoundType.BIRD);
}