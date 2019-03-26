using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanAnimer : MonoBehaviour {

    public float speed;
    public bool forceWalk = false;

    public GameObject destination;

	// Use this for initialization
	void Start ()
    {
        forceWalk = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<FamilyWalkControl>() || forceWalk == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination.transform.position, speed);
            Vector3 move = new Vector3(0f, 0f, transform.forward.sqrMagnitude * speed);
            transform.Translate(move * Time.deltaTime);
        }
    }

}
