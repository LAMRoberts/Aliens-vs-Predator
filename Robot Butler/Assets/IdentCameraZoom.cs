using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentCameraZoom : MonoBehaviour
{
    public Material mat;

    Camera cam = null;

    public float speed = 0.0f;

    public float aSpeed = 0.0f;

    private bool zoom = false;

    private bool albedo = false;

    public bool fade = false;

    private float time = 0.0f;

    public float maxTime = 0.0f;

    private void Start()
    {
       cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    public void StartZoom()
    {
        zoom = true;

        if (fade)
        {
            mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, 0.0f);
        }
        else
        {
            mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, 1.0f);
        }

    }

    void Update ()
    {
		if (Input.GetKeyDown("h"))
        {
            zoom = true;
        }

        if (zoom)
        {
            Zoom();

            Debug.Log("zooming");

            time += Time.deltaTime;

            if (time >= maxTime)
            {
                zoom = false;

                albedo = true;
            }
        }

        if (albedo && fade)
        {
            Albedo();
        }
	}

    private void Zoom()
    {
        cam.fieldOfView = cam.fieldOfView + speed;
    }

    private void Albedo()
    {
        if (mat.color.a < 1.0f)
        {
            mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, mat.color.a + aSpeed);
        }
    }
}
