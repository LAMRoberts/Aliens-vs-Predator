using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    [SerializeField]
    private float TimeTillFadeStart;

    [SerializeField]
    private float TimeTakenToFade;

    private float TotalTime = 0;

    private float AlphaFadePerSec;

	// Use this for initialization
	void Start ()
	{
	    AlphaFadePerSec = 1 / TimeTakenToFade;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    TotalTime += Time.deltaTime;
	    if (TotalTime > TimeTillFadeStart)
	    {
            GetComponent<Text>().color -= new Color(0, 0, 0, AlphaFadePerSec * Time.deltaTime);
	    }

	}
}
