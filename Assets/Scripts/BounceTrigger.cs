using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceTrigger : MonoBehaviour
{
    public BounceControl playerBounce;

    private void OnTriggerEnter(Collider other)
    {
        playerBounce.BounceOn();
    }

}
