using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            SoundManager.PlaySound(SoundType.SUCCESS, 0.8f);
            SceneManager.LoadScene("ExitScene");
            Debug.Log("hit collider");
            
        }
    }
}
