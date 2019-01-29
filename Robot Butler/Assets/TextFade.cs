using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    [SerializeField]
    private bool fade;
    [SerializeField]
    private bool appear;

    [SerializeField]
    private float TimeTillEffectStart;

    [SerializeField]
    private float TimeTakenToChange;

    private float TotalTime = 0;

    private float AlphaChangePerSec;



	// Use this for initialization
	void Start ()
	{
        AlphaChangePerSec = 1 / TimeTakenToChange;
	}
	
	// Update is called once per frame
	void Update ()
	{
	    TotalTime += Time.deltaTime;
	    if (TotalTime > TimeTillEffectStart)
	    {
            if (fade)
            {
                GetComponent<Text>().color -= new Color(0, 0, 0, AlphaChangePerSec * Time.deltaTime);
            }
            if(appear)
            {
                GetComponent<Text>().color += new Color(0, 0, 0, AlphaChangePerSec * Time.deltaTime);
            }
	    }
	}
}
