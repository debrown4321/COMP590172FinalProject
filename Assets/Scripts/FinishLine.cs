using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit collider (outside if)");
        if (other.CompareTag("Player"))
        {
            SoundManager.PlaySound(SoundType.SUCCESS, 0.8f);
            Debug.Log("hit collider");
        }
    }
}
