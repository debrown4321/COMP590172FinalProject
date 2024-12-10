using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReloadCollider : MonoBehaviour
{
    public Gun gunGO;
    BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        boxCollider.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            TriggerOff();
            gunGO.Reloading = false;
            
        }
    }


    public void TriggerOn()
    {
        boxCollider.enabled = true;
    }

    public void TriggerOff()
    {
        boxCollider.enabled = false;
    }

    private void Update()
    {
        if (gunGO.Shooting)
        {
            TriggerOn();
        }
    }
}
