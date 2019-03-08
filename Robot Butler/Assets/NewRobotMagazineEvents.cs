using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRobotMagazineEvents : MonoBehaviour
{
    private enum State
    {
        MAGAZINE, MOVING, HOMEWORK
    }
    private State state = State.MAGAZINE;

    private Animation anim;


    public Transform homework;
    public Transform[] magazines;
    private int activeMagazine = 0;

    public Transform leftAnchor;
    public Transform rightAnchor;

    private bool isHomework = false;
    private bool destReached = false;
    private bool animPlayed = false;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    private void Update()
    {
        switch (state)
        {
            case State.MAGAZINE:
                if (!anim.isPlaying && activeMagazine < magazines.Length)
                    anim.Play("NewRobotMagazine");
                else if (!anim.isPlaying && activeMagazine >= magazines.Length)
                    state = State.MOVING;
                break;
            case State.MOVING:
                isHomework = true;
                if (!anim.isPlaying && !destReached)
                {
                    anim.Play("NewRobotWalk");
                    destReached = true;
                }
                else if (!anim.isPlaying && destReached)
                    state = State.HOMEWORK;
                break;
            case State.HOMEWORK:
                if (!animPlayed)
                {
                    anim.Play("NewRobotHomework");
                    animPlayed = true;
                }
                break;
        }
    }



    public void PickUp()
    {
        Transform mag = homework;

        if (!isHomework)
            mag = magazines[activeMagazine];


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
