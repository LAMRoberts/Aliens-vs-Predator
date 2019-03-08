using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public bool worldAxis = true;
    public Vector3 axes = Vector3.up;

    public float speed = 1;

    private void Start()
    {
        if(!worldAxis) { axes = transform.up; }
    }

    void Update ()
    {
        transform.Rotate(axes * (speed * Time.deltaTime),Space.Self);
    }
}
