using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.PlaySound(SoundType.WIND, 0.5f);
        SoundManager.PlayLoopingSound(SoundType.CITY, 0.8f, 0);
        
    }

    private void OnDestroy()
    {
        //SoundManager.StopLoopingSound();
    }
}
