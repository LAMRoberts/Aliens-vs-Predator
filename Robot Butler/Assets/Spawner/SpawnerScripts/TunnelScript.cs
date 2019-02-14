using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
        }
    }
}