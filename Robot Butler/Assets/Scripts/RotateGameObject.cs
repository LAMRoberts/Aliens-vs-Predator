using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGameObject : MonoBehaviour
{
    public bool worldAxis = true;
    public Vector3 axes = Vector3.up;

    public float speed = 1;

    [SerializeField]
    private bool timer = false;

    [SerializeField]
    private float start_after_secs = 0;
    [SerializeField]
    private float stop_after_secs = 100;

    private float time_passed = 0;

    private void Start()
    {
        if(!worldAxis) { axes = transform.up; }
    }

    void Update ()
    {
        if (timer)
        {
            time_passed += Time.deltaTime;
            if ((time_passed > start_after_secs) && (time_passed < stop_after_secs))
            {
                transform.Rotate(axes * (speed * Time.deltaTime), Space.Self);
            }
        }
        else
        {
            transform.Rotate(axes * (speed * Time.deltaTime), Space.Self);
        }
    }
}
