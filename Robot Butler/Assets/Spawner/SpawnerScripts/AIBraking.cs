using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBraking : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "AIVehicle")
        {
            //GetComponentInParent<VehicleAI>().AddBlocker(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "AIVehicle")
        {
            //GetComponentInParent<VehicleAI>().RemoveBlocker(other.gameObject);
        }
    }
}