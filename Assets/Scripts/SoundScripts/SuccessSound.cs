using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SoundManager.PlaySound(SoundType.SUCCESS, 0.8f);
        SoundManager.PlayLoopingSound(SoundType.INTRO, 0.2f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
