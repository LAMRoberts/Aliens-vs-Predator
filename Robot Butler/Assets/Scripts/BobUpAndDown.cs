using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BobUpAndDown : MonoBehaviour
{
    private float origin;
    private float y = 0;
    [SerializeField]
    private float amount = 1;
    [SerializeField]
    private float speed = 1;

    [SerializeField]
    private float offset_sin = 0;

    [SerializeField]
    private float for_time = -1;

    private bool time_set = false;
    private float delta_time = 0;


    private void Start()
    {
        origin = transform.position.y;

        if(for_time != -1)
        {
            time_set = true;
        }
    }

    private void Update()
    {
        if (delta_time < for_time)
        {
            delta_time += Time.deltaTime;
            y = origin + ((float)Mathf.Sin(((Time.time * speed) + offset_sin)) * amount);
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }
    }
}
