using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.PlaySound(SoundType.SUCCESS, 0.8f);
        //SoundManager.PlayLoopingSound(SoundType.INTRO, 0.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
