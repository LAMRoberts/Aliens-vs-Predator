using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyWalkControl : MonoBehaviour
{
    bool walk = false;
	// Use this for initialization
	void Start () {
        GetComponent<FamilyWalkControl>().walk = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.W))
        {
            walk = !walk;
            GetComponent<Animator>().SetBool("Walk", walk);
            GetComponent<HumanAnimer>().forceWalk = walk;
        }
	}
}
