using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalSceneManager : MonoBehaviour
{
    public TextMeshPro finalTimeText;

    // Start is called before the first frame update
    void Start()
    {
        float finalTime = Timer.GetFinalTime();
        string minutes = ((int)finalTime / 60).ToString("00");
        string seconds = (finalTime % 60).ToString("00");
        finalTimeText.text = "Your Time: " + minutes + ":" + seconds;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
