using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //SoundManager.PlaySound(SoundType.WIND, 0.8f);
        SoundManager.PlayLoopingSound(SoundType.CITY, 0.8f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
