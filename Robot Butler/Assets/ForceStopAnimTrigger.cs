using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceStopAnimTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider Col)
    {
        if(Col.GetComponent<FamilyWalkControl>() != null)
        {
            Col.gameObject.GetComponent<Animator>().SetBool("Walk", false);
            Col.gameObject.GetComponent<HumanAnimer>().speed = 0;
        }
    }
}
