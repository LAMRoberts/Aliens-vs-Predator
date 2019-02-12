using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobUpAndDown : MonoBehaviour
{
    private float origin;
    private float y = 0;
    public float amount = 1;

    private void Start()
    {
        origin = transform.position.y;
    }

    private void Update ()
    {
        y = origin + ((float)Mathf.Sin(Time.time) * amount);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
	}
}
