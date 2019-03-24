using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceRotationLock : MonoBehaviour 
{
    public Transform lookat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0);
        transform.LookAt(lookat);
		
	}
}
