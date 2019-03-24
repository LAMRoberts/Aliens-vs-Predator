using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{

    public GameObject[] Humans;

    float timer;

    public float randomOffsetDistanceMax;

    public float spawnTimer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer > spawnTimer)
        {
            Vector3 offset = new Vector3(Random.Range(-randomOffsetDistanceMax, randomOffsetDistanceMax), 0, Random.Range(-randomOffsetDistanceMax, randomOffsetDistanceMax));
            Instantiate(Humans[Random.Range(0, Humans.Length)], transform.position + offset, transform.rotation);
            timer = 0;
        }
	}
}
