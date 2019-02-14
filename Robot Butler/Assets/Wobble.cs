using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    [SerializeField]
    private float wobble_z_amout;
    [SerializeField]
    private float wobble_z_interval;

    private bool flip_z = false;
    private float z_time = 0;
    private bool z_initial = true;

    void Update()
    {
        z_time += Time.deltaTime;

        //z wobble
        if (z_time > wobble_z_interval)
        {
            flip_z = !flip_z;
            z_time = 0;
            if (z_initial)
            {
                z_initial = false;
                wobble_z_amout *= 2;
            }
        }

        if (flip_z)
        {
            transform.Rotate(Vector3.right, wobble_z_amout * Time.deltaTime);
        }
        else
        {
            transform.Rotate(Vector3.right, -wobble_z_amout * Time.deltaTime);
        }
    }
}
