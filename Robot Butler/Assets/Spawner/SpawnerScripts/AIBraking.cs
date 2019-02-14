using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBraking : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Terrain" || other.gameObject.tag == "Untagged")
        {
            GetComponentInParent<VehicleAI>().AddBlocker(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag != "Terrain" || other.gameObject.tag == "Untagged")
        {
            GetComponentInParent<VehicleAI>().RemoveBlocker(other.gameObject);
        }
    }
}