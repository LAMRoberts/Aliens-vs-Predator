using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 1;
	void Update ()
    {
        transform.Rotate(Vector3.up * (speed * Time.deltaTime));
    }
}
