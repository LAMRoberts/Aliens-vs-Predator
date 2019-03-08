﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyWalkControl : MonoBehaviour
{
    public bool canPoint, canPickUp, canDissapoint, canWalk;

    public bool ANIMATIONFREEZE;

    bool walk = false;
	// Use this for initialization
	void Start () {
        GetComponent<FamilyWalkControl>().walk = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (canWalk)
            {
                walk = !walk;
                GetComponent<Animator>().SetBool("Walk", walk);
                GetComponent<HumanAnimer>().forceWalk = walk;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if(canPoint)
            GetComponent<Animator>().SetTrigger("Point");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (canPickUp)
                GetComponent<Animator>().SetTrigger("Pickup");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (canDissapoint)
                GetComponent<Animator>().SetTrigger("Dissapoint");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ANIMATIONFREEZE)
                GetComponent<Animator>().speed = 0;
        }
    }
}
