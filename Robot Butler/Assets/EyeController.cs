using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    public Material eyeColor;

    private Renderer r;
    private Light l;

    private float range;
    private bool increase = true;
    public float speed = 0.0f;

	void Start ()
    {
        r = GetComponent<Renderer>();
        r.material = eyeColor;

        l = GetComponentInChildren<Light>();
        l.color = eyeColor.color;
	}

	void Update ()
    {
        if (range > 0.8f)
        {
            increase = false;
        }
        else if (range < 0.05f)
        {
            increase = true;
        }

        if (increase)
        {
            range += Time.deltaTime * speed;
        }
        else
        {
            range -= Time.deltaTime * speed;
        }
        
        l.range = range;
	}
}
