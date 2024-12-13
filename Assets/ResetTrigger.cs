using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTrigger : MonoBehaviour
{
    public GameObject player;
    public Transform resetPoint;
    public BounceControl bounce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = resetPoint.position;
            bounce.BounceOff();
        }
    }


}
