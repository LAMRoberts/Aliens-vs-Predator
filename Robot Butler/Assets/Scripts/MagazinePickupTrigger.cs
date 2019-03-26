using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazinePickupTrigger : MonoBehaviour {

    // Use this for initialization

    bool move;
    GameObject mag;
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            mag.transform.position = Vector3.Lerp(mag.transform.position, transform.parent.position, Time.deltaTime * 5);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Magazine")
        {
            other.transform.parent = this.transform.parent.transform;

            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            mag = other.gameObject;

            mag.transform.rotation = transform.parent.rotation;
            move = true;
        }
    }
}
