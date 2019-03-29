using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentFadeIn : MonoBehaviour
{
    public Material mat;
    public float delay = 0.0f;
    public float speed = 1.0f;

    private void Start()
    {
        delay += 1.0f;
    }

    void Update ()
    {
        if (delay > 0.0f)
        {
            delay -= speed * Time.deltaTime;
        }

        mat.color = new Color(mat.color.r, mat.color.g, mat.color.b, delay);
    }
}
