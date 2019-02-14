using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timeBetweenSpawns = 0.0f;
    public float carMaxSpeed = 0.0f;
    public bool carHasLifetime = false;
    public float carLifetime = 0.0f;
    public bool carHasMaxDistance = false;
    public float maxDistance = 0.0f;
    public float separation = 0.0f;

    private GameObject vehicle;
    private VehicleAI ai;
    private GameObject tempVehicle;
    [SerializeField]
    private float timeSinceLastSpawn = 10000.0f;
    public ListOfVehicleTypes Vehicles;
    private List<GameObject> VehicleTypes;
    [SerializeField]
    private float distanceToLastSpawned = 10000.0f;
    [SerializeField]
    private float necessaryDistanceToSpawn = 0.0f;
    private bool nextVehiclePicked = false;

    private void Start()
    {
        vehicle = null;
        tempVehicle = null;

        VehicleTypes = Vehicles.GetList();
    }

    void Update ()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (!nextVehiclePicked)
        {
            tempVehicle = VehicleTypes[Random.Range(0, VehicleTypes.Count)];

            if (vehicle != null)
            {
                necessaryDistanceToSpawn = ai.distanceToRear + separation + tempVehicle.GetComponent<VehicleAI>().distanceToFront;
            }
            else
            {
                necessaryDistanceToSpawn = 0.0f;
            }

            nextVehiclePicked = true;
        }

        if (timeSinceLastSpawn > timeBetweenSpawns && distanceToLastSpawned > necessaryDistanceToSpawn)
        {
            vehicle = Instantiate(tempVehicle, transform);

            ai = vehicle.GetComponent<VehicleAI>();

            ai.SetSpeed(carMaxSpeed);

            if (carHasLifetime)
            {
                ai.SetTimeUntilDeath(carLifetime);
            }

            if (carHasMaxDistance)
            {
                ai.SetMaxDistance(maxDistance);
            }
            
            timeSinceLastSpawn = 0.0f;

            nextVehiclePicked = false;
        }

        if (vehicle != null)
        {
            distanceToLastSpawned = Vector3.Distance(vehicle.transform.position, transform.position);
        }
        else
        {
            distanceToLastSpawned = 10000.0f;
        }
	}
}
