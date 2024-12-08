using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Bullet Info")]
    public GameObject bulletGO;
    public float bulletSpeed;
    Transform bulletTransform;
    Rigidbody bulletRb;
    Bullet bulletScript;

    [Header("Player Info")]
    public GameObject player;
    SpringJoint springJoint;
    [Range(500f, 2000f)]
    public float damper = 500f;
    [Range(1000f, 3000f)]
    public float spring = 1000f;

    [Header("Gun Info")]
    public Transform barrel;
    public bool Shot { get; set; }

    private void Start()
    {
        bulletTransform = bulletGO.transform;
        bulletRb = bulletGO.GetComponent<Rigidbody>();
        bulletScript = bulletGO.GetComponent<Bullet>();
    }

    public void Fire()
    {
        Shot = true;
        bulletTransform.position = barrel.position;
        bulletRb.velocity = barrel.forward * bulletSpeed;
    }

    public void Reload()
    {
        Shot = false;
        Destroy(springJoint);
        bulletScript.DestroyJoint();
    }

    public void Swing()
    {
        springJoint = player.AddComponent<SpringJoint>();
        springJoint.connectedBody = bulletScript.collisionObject.GetComponent<Rigidbody>();
        springJoint.autoConfigureConnectedAnchor = false;
        springJoint.connectedAnchor = bulletScript.collisionObject.transform.InverseTransformPoint(bulletScript.hitPoint);
        springJoint.anchor = Vector3.zero;

        float disJointToPlayer = Vector3.Distance(player.transform.position, bulletTransform.position);

        springJoint.maxDistance = disJointToPlayer * 0.9f;
        springJoint.minDistance = disJointToPlayer * 0.1f;

        springJoint.damper = damper;
        springJoint.spring = spring;
    }

    private void Update()
    {
        if (!Shot)
        {
            bulletTransform.position = barrel.position;
            bulletTransform.forward = barrel.forward;
        }
    }

}
