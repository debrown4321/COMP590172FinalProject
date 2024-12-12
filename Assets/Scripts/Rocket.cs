using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    [Range(1f, 20f)]
    public float movementSpeed;
    public float charge;
    private bool power;

    private void Start()
    {
        charge = 10f;
    }

    void Forward()
    {
        power = true;
    }

    void Recharge()
    {
        power = false;
    }

    private void FixedUpdate()
    {
        //Debug.Log(Time.deltaTime);
        if (Input.GetKeyDown("w"))
        {
            Forward();
        }
        else if (Input.GetKeyUp("w"))
        {
            Recharge();
        }

        if (power && charge > 0)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
            charge -= 2f * Time.deltaTime;
        }
        else if (!power)
        {
            if (charge < 10)
            {
                charge += 0.1f * Time.deltaTime;
            }

        } else if (charge <= 0)
        {
            charge += 1f * Time.deltaTime;
        }
    }
}
