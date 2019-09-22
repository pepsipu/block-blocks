using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    public Transform shield;

    void Update()
    {
        if (Input.GetKey("w")) 
        {
            shield.position = new Vector3(0, 1, (float) 0.75);
            shield.rotation = Quaternion.Euler(0,0,0);
        }
        else if (Input.GetKey("s"))
        {
            shield.position = new Vector3(0, 1, (float) -0.75);
            shield.rotation = Quaternion.Euler(0,0,0);
        }
        else if (Input.GetKey("a"))
        {
            shield.position = new Vector3((float) -0.75, 1, 0);
            shield.rotation = Quaternion.Euler(0,90,0);
        }
        else if (Input.GetKey("d"))
        {
            shield.position = new Vector3((float) 0.75, 1, 0);
            shield.rotation = Quaternion.Euler(0,90,0);
        }
    }
}
