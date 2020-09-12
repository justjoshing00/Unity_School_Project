using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTravel : MonoBehaviour
{
   
    float Bspeed = 0.005f;
    // Update is called once per frame
    void Update()

    {
        transform.position += Vector3.up * Bspeed;
    }
}
