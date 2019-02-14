using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineEvents : MonoBehaviour
{
    private enum State
    {
        MAGAZINE, MOVING, HOMEWORK
    }
    private State state = State.MAGAZINE;

    public Transform homework;
    public Transform[] magazines;
    public Transform anchorPoint;

    private Vector3 anchorPosition = new Vector3(0.157f, 0.058f, -0.03f);
    private Vector3 anchorRotation = new Vector3(17.26f, -92.489f, 13.849f);

    private Animation anim;
    private int currentMagazine = 0;

    private Vector3 origin = new Vector3(-2.7f, 0, -0.26f);
    private Vector3 target = new Vector3(0.042f, 0, -0.4f);
    public float moveSpeed = 1;

    private bool animPlayed = false;

    private void Start()
    {
        transform.position = origin;
        anim = GetComponent<Animation>();
    }
    
    private void Update()
    {
        switch (state)
        {
            case State.MAGAZINE:
                if (!anim.isPlaying && currentMagazine < magazines.Length)
                    anim.Play("MagazineInBin");
                else if (!anim.isPlaying && currentMagazine >= magazines.Length)
                    state = State.MOVING;
                break;
            case State.MOVING:
                transform.position = Vector3.MoveTowards(
                    transform.position, target, 
                    Time.deltaTime * moveSpeed);
                transform.LookAt(target);

                if (transform.position == target)
                    state = State.HOMEWORK;
                break;
            case State.HOMEWORK:
                if (!animPlayed)
                {
                    anim.Play("LookAtMagazine");
                    animPlayed = true;
                }
                break;
        }
    }

    public void AttachMagazine(int isHomework = 0)
    {
        Transform mag = null;
        if (isHomework != 0)
        {
            mag = homework;
        }
        else
        {
            mag = magazines[currentMagazine];
        }
        mag.parent = anchorPoint;
        mag.localPosition = anchorPosition;
        mag.localEulerAngles = anchorRotation;
    }

    public void DetachMagazine()
    {
        magazines[currentMagazine].transform.parent = null;
        magazines[currentMagazine].gameObject.AddComponent<Rigidbody>();

        currentMagazine++;
    }
}
