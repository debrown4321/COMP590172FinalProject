using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Bullet Info")]
    public GameObject bulletGO;
    public float bulletSpeed;
    public float reloadSpeed;
    Transform bulletTransform;
    Rigidbody bulletRb;
    Bullet bulletScript;

    [Header("Player Info")]
    public GameObject player;
    SpringJoint springJoint;
    [Range(1f, 20f)]
    public float damper = 7f;
    [Range(1f, 20f)]
    public float spring = 4.5f;
    [Range(1f, 20f)]
    public float massScale = 4.5f;

    [Header("Gun Info")]
    public Transform barrel;
    public LineRenderer lr;
    public bool Shooting { get; set; }
    public bool Reloading { get; set; }

    private void Start()
    {
        bulletTransform = bulletGO.transform;
        bulletRb = bulletGO.GetComponent<Rigidbody>();
        bulletScript = bulletGO.GetComponent<Bullet>();
        lr = gameObject.GetComponent<LineRenderer>();
        Shooting = false;
        Reloading = false;
        lr.positionCount = 2;
    }

    public void Fire()
    {
        lr.positionCount = 2;
        bulletGO.SetActive(true);
        Shooting = true;
        bulletTransform.position = barrel.position;
        bulletRb.velocity = barrel.forward * bulletSpeed;
        
    }

    public void Reload()
    {
        Shooting = false;
        Reloading = true;
        Destroy(springJoint);
        bulletScript.DestroyJoint();
        lr.positionCount = 0;

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
        springJoint.massScale = massScale;

        
    }

    void DrawRope()
    {
        if (Shooting)
        {
            lr.SetPosition(0, barrel.position);
            lr.SetPosition(1, bulletTransform.position);
        }
    }

    private void Update()
    {

        if (!Shooting && !Reloading)
        {
            bulletGO.SetActive(false);
            bulletTransform.position = barrel.position;
            bulletTransform.forward = barrel.forward;
        } 
        else if (Reloading)
        {
            bulletTransform.position = Vector3.MoveTowards(bulletTransform.position, barrel.position, reloadSpeed);
        }
    }

    private void LateUpdate()
    {
        DrawRope();
    }

}
