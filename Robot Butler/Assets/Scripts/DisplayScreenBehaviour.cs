using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScreenBehaviour : MonoBehaviour {

    public Animation[] UIAnims;

    private void Start()
    {
        StartCoroutine(AnimText());
    }

    IEnumerator AnimText()
    {
        while (true)
        {
            foreach (Animation anim in UIAnims)
            {
                anim.Play();
                yield return new WaitForSeconds(2.5f);
            }
            yield return null;
        }
    }
}
