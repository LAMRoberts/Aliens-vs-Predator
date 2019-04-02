using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handshake : MonoBehaviour
{
    public GameObject robot;

    public float time_till_handshake;
    private float time_passed = 0;

    private void Update()
    {
        time_passed += Time.deltaTime;
        if(time_passed > time_till_handshake)
        {
            ActivateHandShake();
        }
    }

    public void ActivateHandShake()
    {
        GetComponent<Animator>().SetTrigger("HandShake");
        robot.GetComponent<Animator>().enabled = true;
    }
}
