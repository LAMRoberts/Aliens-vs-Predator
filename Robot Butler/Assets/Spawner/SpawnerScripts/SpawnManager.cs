using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float timeBetweenSpawns = 0.0f;
    public bool carHasTimeBetweenSpawnsRange = false;
    public float carTimeBetweenSpawnMin = 0.0f;
    public float carTimeBetweenSpawnMax = 0.0f;
    private bool readyToSpawn = false;
    private float timeBetweenSpawnRNG = 0.0f;
    public float carMaxSpeed = 0.0f;
    public float carBrakingSpeed = 0.0f;
    public bool carHasLifetime = false;
    public float carLifetime = 0.0f;
    public bool carHasMaxDistance = false;
    public float maxDistance = 0.0f;
    public float separation = 0.0f;

    private GameObject vehicle;
    private VehicleAI ai;
    [SerializeField]
    private GameObject tempVehicle;
    private float timeSinceLastSpawn = 10000.0f;
    public ListOfVehicleTypes Vehicles;
    [SerializeField]
    private List<GameObject> VehicleTypes;
    private float distanceToLastSpawned = 10000.0f;
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

        timeSinceLastSpawn += Time.deltaTime;

        if (carHasTimeBetweenSpawnsRange)
        {
            if (timeBetweenSpawnRNG == 0.0f)
            {
                timeBetweenSpawnRNG = Random.Range(carTimeBetweenSpawnMin, carTimeBetweenSpawnMax);
            }

            if (timeSinceLastSpawn > timeBetweenSpawnRNG)
            {
                readyToSpawn = true;
            }
        }
        else
        {
            if (timeSinceLastSpawn > timeBetweenSpawns)
            {
                readyToSpawn = true;
            }
        }

        
        if (readyToSpawn && distanceToLastSpawned > necessaryDistanceToSpawn)
        {
            vehicle = Instantiate(tempVehicle, transform);

            ai = vehicle.GetComponent<VehicleAI>();

            ai.SetMaxSpeed(carMaxSpeed);

            ai.SetBrakingSpeed(carBrakingSpeed);

            if (carHasLifetime)
            {
                ai.SetTimeUntilDeath(carLifetime);
            }

            if (carHasMaxDistance)
            {
                ai.SetMaxDistance(maxDistance);
            }

            if (carHasTimeBetweenSpawnsRange)
            {
                timeBetweenSpawnRNG = 0.0f;
            }

            timeSinceLastSpawn = 0.0f;
            readyToSpawn = false;
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
