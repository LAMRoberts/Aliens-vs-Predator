using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour {

    public List<GameObject> CameraList = new List<GameObject>();
    int currentCam = 0;

	// Use this for initialization
	void Start ()
    {
		foreach (GameObject c in CameraList)
        {
            c.SetActive(false);
        }

        CameraList[0].SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentCam < CameraList.Count)
            {
                currentCam++;

                CameraList[currentCam].SetActive(true);
                CameraList[currentCam - 1].SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (currentCam > 0)
            {
                currentCam--;

                CameraList[currentCam].SetActive(true);
                CameraList[currentCam + 1].SetActive(false);
            }
        }
    }
}
