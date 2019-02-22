using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfVehicleTypes : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> vehicleTypes;

    public bool car;
    public bool cruiser;
    public bool taxi;
    public bool van;
    public bool wagon;
    public bool bus;
    public bool rig;

    public bool liam;
    public bool malcolm;
    public bool regina;
    public bool remy;
    public bool shae;
    public bool stefani;

    private void Start()
    {
        if (car)
        {
            GameObject AI_Car = (GameObject)Resources.Load("AI_Car", typeof(GameObject));
            vehicleTypes.Add(AI_Car);
        }

        if (cruiser)
        {
            GameObject AI_Cruiser = (GameObject)Resources.Load("AI_Cruiser", typeof(GameObject));
            vehicleTypes.Add(AI_Cruiser);
        }

        if (taxi)
        {
            GameObject AI_Taxi = (GameObject)Resources.Load("AI_Taxi", typeof(GameObject));
            vehicleTypes.Add(AI_Taxi);
        }

        if (van)
        {
            GameObject AI_Van = (GameObject)Resources.Load("AI_Van", typeof(GameObject));
            vehicleTypes.Add(AI_Van);
        }

        if (wagon)
        {
            GameObject AI_Wagon = (GameObject)Resources.Load("AI_Wagon", typeof(GameObject));
            vehicleTypes.Add(AI_Wagon);
        }

        if (bus)
        {
            GameObject AI_Bus = (GameObject)Resources.Load("AI_Bus", typeof(GameObject));
            vehicleTypes.Add(AI_Bus);
        }

        if (rig)
        {
            GameObject AI_Rig = (GameObject)Resources.Load("AI_Rig", typeof(GameObject));
            vehicleTypes.Add(AI_Rig);
        }

        if (liam)
        {
            GameObject AI_liam = (GameObject)Resources.Load("liam", typeof(GameObject));
            vehicleTypes.Add(AI_liam);
        }

        if (malcolm)
        {
            GameObject AI_malcolm = (GameObject)Resources.Load("malcolm", typeof(GameObject));
            vehicleTypes.Add(AI_malcolm);
        }

        if (regina)
        {
            GameObject AI_regina = (GameObject)Resources.Load("regina", typeof(GameObject));
            vehicleTypes.Add(AI_regina);
        }

        if (remy)
        {
            GameObject AI_remy = (GameObject)Resources.Load("remy", typeof(GameObject));
            vehicleTypes.Add(AI_remy);
        }

        if (shae)
        {
            GameObject AI_shae = (GameObject)Resources.Load("shae", typeof(GameObject));
            vehicleTypes.Add(AI_shae);
        }

        if (stefani)
        {
            GameObject AI_stefani = (GameObject)Resources.Load("stefani", typeof(GameObject));
            vehicleTypes.Add(AI_stefani);
        }
    }

    public List<GameObject> GetList()
    {
        return vehicleTypes;
    }
}
