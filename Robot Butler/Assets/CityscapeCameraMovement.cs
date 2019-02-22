using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityscapeCameraMovement : MonoBehaviour
{
    public List<Transform> positions;
    public float distance = 0.0f;
    public float positionSpeed = 0.0f;
    public float rotationSpeed = 0.0f;
    private Transform target;
    private int t = 0;
    private bool go = false;

    private void Start()
    {
        target = positions[t];

        transform.position = target.position;
        transform.rotation = target.rotation;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey("c"))
        {
            go = true;
        }

		if (go)
        {
            if (Vector3.Distance(transform.position, target.position) > distance)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, positionSpeed);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, rotationSpeed);

                Debug.Log("moving");
            }
            else
            {
                t++;
                target = positions[t];

                Debug.Log(target);
            }
        }
	}
}
