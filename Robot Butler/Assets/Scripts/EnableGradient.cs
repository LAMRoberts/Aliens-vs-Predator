using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGradient : MonoBehaviour
{
    public GameObject gradient;
    public GameObject sentientE;

	void Start ()
    {
        StartCoroutine(_Enable());
	}

    IEnumerator _Enable()
    {
        yield return new WaitForSeconds(6.0f);

        gradient.SetActive(true);
        sentientE.SetActive(true);
    }
}
