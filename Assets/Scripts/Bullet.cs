using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Gun gun;
    FixedJoint fixedJoint;

    [HideInInspector]
    public GameObject collisionObject;
    public Vector3 hitPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            SoundManager.PlaySound(SoundType.THUD, 0.4f);
            hitPoint = collision.contacts[0].point;
            collisionObject = collision.gameObject;
            fixedJoint = gameObject.AddComponent<FixedJoint>();
            fixedJoint.connectedBody = collision.gameObject.GetComponent<Rigidbody>();

            gun.Swing();
        }
    }

    public void DestroyJoint()
    {
        Destroy(fixedJoint);
    }
}
