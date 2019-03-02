using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppearIn : MonoBehaviour
{
    [SerializeField]
    private string DesiredText;

    [SerializeField]
    private float TimeTillNextLetter;

    [SerializeField]
    private float TimeTillAppearStart;

    [SerializeField]
    private float TimeTakenToAppear;

    private float TotalTime = 0;

    private float TimeSinceLastLetter = 0;
    private int LettersAdded = 0;

    private float AlphaGainPerSec;

    [SerializeField]
    private bool backwards = false;


    // Use this for initialization
    void Start()
    {
        AlphaGainPerSec = 1 / TimeTakenToAppear;

        if(backwards)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > TimeTillAppearStart)
        {
            GetComponent<Text>().color += new Color(0, 0, 0, AlphaGainPerSec * Time.deltaTime);

            if (backwards)
            {
                if (LettersAdded < DesiredText.Length)
                {
                    TimeSinceLastLetter += Time.deltaTime;
                }

                if (TimeSinceLastLetter > TimeTillNextLetter)
                {
                    GetComponent<Text>().text = DesiredText[DesiredText.Length - (LettersAdded + 1)] + GetComponent<Text>().text;
                    LettersAdded++;
                    TimeSinceLastLetter = 0;
                }
            }
            else
            {
                if (LettersAdded < DesiredText.Length)
                {
                    TimeSinceLastLetter += Time.deltaTime;
                }

                if (TimeSinceLastLetter > TimeTillNextLetter)
                {
                    GetComponent<Text>().text += DesiredText[LettersAdded];
                    LettersAdded++;
                    TimeSinceLastLetter = 0;
                }
            }
        }
    }
}
