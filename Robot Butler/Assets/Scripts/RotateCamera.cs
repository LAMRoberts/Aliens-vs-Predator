using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Vector3 axes = Vector3.up;

    public float speed = 1;
	void Update ()
    {
        transform.Rotate(axes * (speed * Time.deltaTime));
    }
}
