using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSlidingDoor : MonoBehaviour
{
    public Transform leftDoor;
    public Transform rightDoor;
    public float topSpeed;
    public float acceleration;
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey("d"))
        {
            OpenDoor();
        }

        if (Input.GetKey("a"))
        {
            CloseDoor();
        }
    }

    void OpenDoor()
    {
        leftDoor.Translate(new Vector3(0, topSpeed * acceleration, 0), Space.Self);
        rightDoor.Translate(new Vector3(0, topSpeed * acceleration, 0), Space.Self);

        if (acceleration < 1.0f)
        {
            acceleration += 0.01f;
        }
    }

    void CloseDoor()
    {
        leftDoor.Translate(new Vector3(0, -topSpeed * 10, 0), Space.Self);
        rightDoor.Translate(new Vector3(0, -topSpeed * 10, 0), Space.Self);
    }
}
