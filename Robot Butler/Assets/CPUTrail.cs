using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPUTrail : MonoBehaviour
{
    public TrailRenderer[] trails;
    private float startTime = 0;
    private float animTime = 0;
    public ParticleSystem poof;
    public ParticleSystem poof2;

    //private float timeElapsed = 0;
    //private float start = 3.5f;
    //private float duration = 2.2f;

    private void Start()
    {
        startTime = trails[0].time;
        animTime = 0.2f;
    }
  //  private void Update ()
  //  {
		//if (timeElapsed >= start && timeElapsed <= start + duration)
  //      {
  //          trail.time = animTime;
  //      }
  //      else
  //      {
  //          trail.time = startTime;
  //      }

  //      timeElapsed += Time.deltaTime;
  //  }
    public void SetStartTime()
    {
        foreach (TrailRenderer trail in trails)
            //trail.time = startTime;
            trail.emitting = false;
    }
    public void SetAnimTime()
    {
        foreach (TrailRenderer trail in trails)
            //trail.time = animTime;
            trail.emitting = true;
    }
    public void PlayPoof()
    {
        poof.Play();
        poof2.Play();
    }
}
