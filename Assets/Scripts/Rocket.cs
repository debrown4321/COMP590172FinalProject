using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    [Range(1f, 20f)]
    public float movementSpeed;
    private float charge = 10f;
    private bool power;

    void Forward()
    {
        
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

    void Recharge()
    {
        power = false;
    }

    private void Update()
    {
        if (power)
        {
            charge -= 0.1f;
        } else
        {
            while (charge < 10f)
            {
                charge += 0.1f;
            }
        }
    }
}
