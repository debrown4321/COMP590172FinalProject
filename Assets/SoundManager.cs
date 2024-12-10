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
    CLOCK

}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{

    [SerializeField] private AudioClip[] soundList;
    private static SoundManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(SoundType sound, float volume = 1)
    {
        instance.audioSource.PlayOneShot(instance.soundList[(int)sound], volume);
    }

    //EXAMPLE USAGE: SoundManager.PlaySound(SoundType.BIRD);
}
