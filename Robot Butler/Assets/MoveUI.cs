using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUI : MonoBehaviour
{
    [SerializeField]
    private float TimeTillMoveStart;

    [SerializeField]
    private Transform TargetTransform;

    [SerializeField]
    private float TimeToTarget;

    private float TotalTime = 0;

    private bool MoveSpeedSet = false;
    private float MoveSpeedPerSec;

	void Update ()
	{
	    TotalTime += Time.deltaTime;

	    if (TotalTime > TimeTillMoveStart && TotalTime < (TimeTillMoveStart + TimeToTarget))
	    {
	        if (!MoveSpeedSet)
	        {
	            CalcMoveSpeed();
	        }

	        GetComponent<RectTransform>().position =
	            Vector3.MoveTowards(GetComponent<RectTransform>().position, TargetTransform.position,
	                MoveSpeedPerSec * Time.deltaTime);
	    }
	}

    void CalcMoveSpeed()
    {
        MoveSpeedSet = true;
        MoveSpeedPerSec = Vector3.Distance(transform.position, TargetTransform.position) / TimeToTarget;
    }
}
