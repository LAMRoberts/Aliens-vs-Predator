using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticleEffect : MonoBehaviour {

    [SerializeField]
    private float TimeTillParticleSpawn;

    private float TimePassed = 0;
    private bool has_played = false;
	
	// Update is called once per frame
	void Update ()
    {
        TimePassed += Time.deltaTime;

		if((TimePassed > TimeTillParticleSpawn) && !has_played)
        {
            has_played = true;
            GetComponent<ParticleSystem>().Play();
        }
	}
}
