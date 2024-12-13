using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BounceControl : MonoBehaviour
{

    public Gun leftGun, rightGun;
    public PhysicMaterial bounce, noBounce;
    private CapsuleCollider playerCollider;

    private void Start()
    {
        playerCollider = GetComponent<CapsuleCollider>();
    }

    public void BounceOn()
    {
        playerCollider.material = bounce;
    }

    public void BounceOff()
    {
        playerCollider.material = noBounce;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log(collision.gameObject.tag);
            leftGun.Reload();
            rightGun.Reload();
        }
    }
}
