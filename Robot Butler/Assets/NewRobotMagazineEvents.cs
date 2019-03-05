using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRobotMagazineEvents : MonoBehaviour
{
    public Transform[] magazines;
    private int activeMagazine = 0;

    public Transform leftAnchor;
    public Transform rightAnchor;

	public void PickUp()
    {
        Transform mag = magazines[activeMagazine];
        mag.parent = rightAnchor;
        mag.localPosition = Vector3.zero;
        mag.localEulerAngles = Vector3.zero;
    }

    public void SwapHands()
    {
        Transform mag = magazines[activeMagazine];
        mag.parent = leftAnchor;
        mag.localPosition = Vector3.zero;
        mag.localEulerAngles = Vector3.zero;
    }

    public void Drop()
    {
        Transform mag = magazines[activeMagazine];
        mag.parent = null;
        mag.gameObject.AddComponent<Rigidbody>();

        activeMagazine++;
    }
}
