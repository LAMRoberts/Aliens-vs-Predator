using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSlotter : MonoBehaviour
{
    public Transform rotPoint;
    public GameObject mag;
    public GameObject magMovePos;
    bool end;
    Vector3 startRot;
    Vector3 startPos;

    float step = 0;

    // Use this for initialization
    void Start ()
    {
        startPos = transform.position;
        startRot = transform.rotation.eulerAngles;
    }
	
	// Update is called once per frame
	void Update ()
    {
       
        if (!end)
        {
            step += Time.deltaTime * 2;
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, rotPoint.transform.rotation.eulerAngles, step);
            transform.position = Vector3.Lerp(transform.position, rotPoint.transform.position, step);

            if (step > 0.9f)
            {
                mag.transform.position = Vector3.MoveTowards(mag.transform.position, magMovePos.transform.position, Time.deltaTime * 0.8f);

                if (mag.transform.position == magMovePos.transform.position)
                {
                    mag.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                    end = true;
                }
            }
        }
        else
        {
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, startRot, Time.deltaTime * 5);
            transform.position = Vector3.Lerp(transform.position, startPos, Time.deltaTime * 5);
        }

    }
}
