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
    }

    public List<GameObject> GetList()
    {
        return vehicleTypes;
    }
}
