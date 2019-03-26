using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEyes : MonoBehaviour
{
    private Material mat;
    public Texture redEyes;
    public Texture deadEyes;

    private void Start()
    {
        mat = GetComponent<SkinnedMeshRenderer>().material;
        mat.mainTexture = redEyes;
        StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        yield return new WaitForSeconds(1.0f);
        mat.mainTexture = deadEyes;
        yield return new WaitForSeconds(0.2f);
        mat.mainTexture = redEyes;
        yield return new WaitForSeconds(0.6f);
        mat.mainTexture = deadEyes;

        yield return new WaitForSeconds(0.4f);
        mat.mainTexture = redEyes;
        yield return new WaitForSeconds(0.1f);
        mat.mainTexture = deadEyes;
        yield return new WaitForSeconds(0.1f);
        mat.mainTexture = redEyes;
        yield return new WaitForSeconds(0.1f);
        mat.mainTexture = deadEyes;
        yield return new WaitForSeconds(0.1f);
        mat.mainTexture = redEyes;

        yield return new WaitForSeconds(0.2f);
        mat.mainTexture = deadEyes;
    }
}
