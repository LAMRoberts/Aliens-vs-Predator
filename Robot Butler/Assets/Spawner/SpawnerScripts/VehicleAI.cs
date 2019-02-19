using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleAI : MonoBehaviour
{
    [SerializeField]
    private float maxSpeed = 0.0f;
    [SerializeField]
    private float currentSpeed = 0.0f;
    [SerializeField]
    private float brakingSpeed = 0.0f;
    [SerializeField]
    private float lifetime = 3600.0f;
    [SerializeField]
    private float maxDistance = 10000.0f;
    [SerializeField]
    private float distance = 0.0f;
    [SerializeField]
    private List<GameObject> blockers;
        
    public float distanceToRear = 0.0f;
    public float distanceToFront = 0.0f;

    void Update()
    {
        transform.position += (Time.deltaTime * transform.forward * currentSpeed);

        distance = Vector3.Distance(transform.position, transform.parent.position);

        if (lifetime < 0.0f || distance > maxDistance)
        {
            Destroy(gameObject);
        }
        else
        {
            lifetime -= Time.deltaTime;
        }

        if (blockers.Count > 0)
        {
            if (tag == "AIVehicle")
            {
                if (currentSpeed > 0.0f)
                {
                    currentSpeed -= currentSpeed * brakingSpeed;
                }
            }
            else if (tag == "AIPerson")
            {
                if (GetComponent<HumanAnimer>().speed != 0.0f)
                {
                    GetComponent<HumanAnimer>().speed = 0.0f;

                    GetComponent<Animator>().SetFloat("walkSpeedMultiplier", 0.0f);
                }
            }
        }
        else
        {
            if (tag == "AIVehicle")
            {
                if (currentSpeed < maxSpeed)
                {
                    currentSpeed += (maxSpeed - currentSpeed) * 0.01f;
                }
            }
            else if (tag == "AIPerson")
            {
                if (GetComponent<HumanAnimer>().speed != 2.0f)
                {
                    GetComponent<HumanAnimer>().speed = 2.0f;

                    GetComponent<Animator>().SetFloat("walkSpeedMultiplier", 1.0f);
                }
            }
        }
    }

    public void SetMaxSpeed(float value)
    {
        maxSpeed = value;
    }

    public void SetBrakingSpeed(float value)
    {
        brakingSpeed = value;
    }

    public void SetTimeUntilDeath(float value)
    {
        lifetime = value;
    }

    public void SetMaxDistance(float value)
    {
        maxDistance = value;
    }

    public void AddBlocker(GameObject vehicle)
    {
        blockers.Add(vehicle);
    }

    public void RemoveBlocker(GameObject vehicle)
    {
        blockers.Remove(vehicle);
    }
}