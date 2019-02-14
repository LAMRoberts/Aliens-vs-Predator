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
    private float lifetime = 3600.0f;
    [SerializeField]
    private float maxDistance = 0.0f;
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
            foreach (GameObject blocker in blockers)
            {
                if (currentSpeed > 0.0f)
                {
                    currentSpeed -= currentSpeed * 0.05f; ;
                }
            }
        }
        else
        {
            if (currentSpeed < maxSpeed)
            {
                currentSpeed += (maxSpeed - currentSpeed) * 0.01f;
            }
        }
    }

    public void SetSpeed(float value)
    {
        maxSpeed = value;
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