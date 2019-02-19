using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBraking : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (transform.parent.tag == "AIPerson")
        {
            GetComponentInParent<VehicleAI>().AddBlocker(other.gameObject);
        }

        if (other.transform.tag == "AIVehicle" || other.transform.tag == "AIPerson" || other.transform.tag == "TrafficStopper")
        {
            GetComponentInParent<VehicleAI>().AddBlocker(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (transform.parent.tag == "AIPerson")
        {
            GetComponentInParent<VehicleAI>().RemoveBlocker(other.gameObject);
        }

        if (other.transform.tag == "AIVehicle" || other.transform.tag == "AIPerson" || other.transform.tag == "TrafficStopper")
        {
            GetComponentInParent<VehicleAI>().RemoveBlocker(other.gameObject);
        }
    }
}