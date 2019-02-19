using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAnimer : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 move = new Vector3(0f, 0f, transform.forward.sqrMagnitude * speed);
        transform.Translate(move * Time.deltaTime);
	}
}
