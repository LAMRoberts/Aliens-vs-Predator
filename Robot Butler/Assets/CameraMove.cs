using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject CameraTargetPos;

    [SerializeField]
    private bool camera_switch;

    [SerializeField]
    private GameObject CameraSwitch;

    [SerializeField]
    private float switch_delay;

    [SerializeField]
    private float time_to_target;

    [SerializeField]
    private float time_till_start;
    private float time_passed;

    private float dis_per_sec;
    [SerializeField]
    private float rotate_speed;


    private void Start()
    {
        float dis = Vector3.Distance(transform.position, CameraTargetPos.transform.position);
        dis_per_sec = dis / time_to_target;        
    }

    private void Update()
    {
        time_passed += Time.deltaTime;

        if (time_passed > time_till_start)
        {
            transform.position =  Vector3.MoveTowards(transform.position, CameraTargetPos.transform.position, dis_per_sec * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, CameraTargetPos.transform.rotation, rotate_speed * Time.deltaTime);
        }
        if (camera_switch)
        {
            if (time_passed > (time_to_target + time_till_start + switch_delay))
            {
                CameraSwitch.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
