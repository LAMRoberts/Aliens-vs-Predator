using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBraking : MonoBehaviour
{
    public List<string> tags = new List<string>() { "AIPerson", "AIVehicle", "TrafficStopper", "Crossing"};

    private void OnTriggerEnter(Collider other)
    {
        if (transform.parent.tag == "AIPerson" || transform.parent.tag == "AIVehicle")
        {
            if (CheckTag(other.transform.tag))
            {
                GetComponentInParent<VehicleAI>().AddBlocker(other.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (transform.parent.tag == "AIPerson" || transform.parent.tag == "AIVehicle")
        {
            if (CheckTag(other.transform.tag))
            {
                GetComponentInParent<VehicleAI>().RemoveBlocker(other.gameObject);
            }
        }
    }

    /// <summary>
    /// returns true if tag is in list of tags to stop for
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    private bool CheckTag(string tag)
    {
        foreach (string t in tags)
        {
            if (tag == t)
            {
                return true;
            }            
        }

        return false;
    }
}