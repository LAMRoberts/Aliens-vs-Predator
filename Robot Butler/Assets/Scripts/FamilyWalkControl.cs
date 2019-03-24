﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyWalkControl : MonoBehaviour
{
    public bool canPoint, canPickUp, canDissapoint, canWalk;

    public bool ANIMATIONFREEZE;
    public Transform magazine;
    public Transform head;

    bool walk = false;
    // Use this for initialization
    void Start()
    {
        GetComponent<FamilyWalkControl>().walk = false;
            //  GetComponent<Animator>().SetTrigger("Dissapoint");

        //  ActivateHandShake();
    }

    // Update is called once per frame
    void Update()
    {
        if (magazine != null)
        {
            Debug.Log("Looking at magazine");
            head.LookAt(magazine);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (canWalk)
            {
                walk = !walk;
                if (gameObject.name == "Mum")
                {
                    GetComponent<Animator>().SetBool("LookAtMag", walk);
                    GetComponent<Animator>().SetBool("Walk", walk);
                }
                else
                {
                    GetComponent<Animator>().SetBool("Walk", walk);
                }
                GetComponent<HumanAnimer>().forceWalk = walk;
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (canPoint)
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

        if (Input.GetKeyDown(KeyCode.Y))
        {
            if (canDissapoint)
                GetComponent<Animator>().SetTrigger("Victory");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ANIMATIONFREEZE)
                GetComponent<Animator>().speed = 0;
        }
    }

    public void ActivateHandShake()
    {
        GetComponent<Animator>().SetTrigger("HandShake");
    }
}