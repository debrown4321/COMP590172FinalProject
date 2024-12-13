using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeButton : MonoBehaviour
{

    public string gameSceneName;

    private void OnTriggerEnter(Collider other)
    {
        SoundManager.PlaySound(SoundType.SUCCESS, 0.8f);
        SceneManager.LoadScene(gameSceneName);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
