using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unityTimeScaler : MonoBehaviour {

	// Use this for initialization

        int timesscale = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (timesscale >= 1 && timesscale < 100)
            {
                timesscale++;
                Time.timeScale = 1 * timesscale;
            }
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (timesscale > 1)
            {
                timesscale--;
                Time.timeScale = 1 * timesscale;
            }
        }
	}
}
