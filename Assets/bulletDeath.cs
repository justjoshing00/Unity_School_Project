using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDeath : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("triggered");
    }
}
