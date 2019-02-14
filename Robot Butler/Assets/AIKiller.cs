using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIKiller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "AIVehicle")
        {
            Destroy(other.gameObject);
        }
    }
}