using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlimpMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 2f;

    [SerializeField]
    private Vector3 direction = Vector3.left;

    [SerializeField]
    private float boundaryX = 10f;

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Mathf.Abs(transform.position.x) < boundaryX)
        {

            ResetPosition();

        }
    }

    void ResetPosition()
    {
        // Assuming the blimp moves right, reset to left boundary
        if (direction == Vector3.right)
        {
            transform.position = new Vector3(-boundaryX, transform.position.y, transform.position.z);
        }
        else if (direction == Vector3.left)
        {
            transform.position = new Vector3(boundaryX, transform.position.y, transform.position.z);
        }
        // Add more conditions if moving along different axes
    }
}