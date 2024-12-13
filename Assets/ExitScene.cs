using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalSceneManager : MonoBehaviour
{
    public TextMeshPro finalTimeText; // Reference to the UI Text component

    void Start()
    {
        float finalTime = Timer.GetFinalTime(); // Retrieve the final time
        string minutes = ((int)finalTime / 60).ToString("00");
        string seconds = (finalTime % 60).ToString("00");
        finalTimeText.text = "Final Time: " + minutes + ":" + seconds;
    }
}

