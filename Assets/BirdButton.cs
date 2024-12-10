using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdButton : MonoBehaviour
{
    public SoundType soundType; // Assign this in the Unity Inspector

    public void PlaySound()
    {
        SoundManager.PlaySound(soundType);
    }
}
