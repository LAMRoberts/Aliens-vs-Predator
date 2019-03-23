using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpyboy : MonoBehaviour {

    public Transform[] lerpers;
    public float speed;
    int transIter = 0;
    float time = 0;
    float rottime = 0;
    float delay = 0;
    public float delaytimer;
    float currentSpeed;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        delay += Time.deltaTime;
        if (delay > delaytimer)
        {
            if (time < 1)
            {
                if(currentSpeed <= speed)
                    currentSpeed += Time.deltaTime / 5;

                time += currentSpeed * Time.deltaTime;
                Vector3 p1 = Vector3.Lerp(lerpers[0].position, lerpers[1].position, time);
                Vector3 p2 = Vector3.Lerp(lerpers[1].position, lerpers[2].position, time);
                transform.position = Vector3.Lerp(p1, p2, time);
            }
            rottime += currentSpeed * Time.deltaTime / 12.5f;
            transform.rotation = Quaternion.Lerp(transform.rotation, lerpers[2].rotation, rottime);
        }
    }
}
