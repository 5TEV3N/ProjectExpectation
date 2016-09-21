﻿using UnityEngine;
using System.Collections;

public class HomeTrigger : MonoBehaviour
{
    public GameObject titleAlphabet;
    public GameObject titleCode;

    public GameObject tut1;
    public GameObject tut2;

    public GameObject hiddenGoal1;  //Goal
    public GameObject hiddenCover1;  //Cover1
    public GameObject hiddenCover2;  //Cover2
    public GameObject hiddenTip;  //LookAround - UnScramble

    public GameObject hiddenFloatingClue1;  //D
    public GameObject hiddenFloatingClue2;  //E
    public GameObject hiddenFloatingClue3;  //L
    public GameObject hiddenFloatingClue4;  //E
    public GameObject hiddenFloatingClue5;  //T
    public GameObject hiddenFloatingClue6;  //E

    public bool challenge1Done = false;
    public bool challenge2Done = false;

    Fadeing fadeing;
    Fadeing2 fadeing2;
    Fadeing3 fadeing3;
    AudioController audioController;

    void Awake()
    {
        fadeing = GameObject.FindGameObjectWithTag("T_Fade").GetComponent<Fadeing>();
        fadeing2 = GameObject.FindGameObjectWithTag("T_Fade2").GetComponent<Fadeing2>();
        fadeing3 = GameObject.FindGameObjectWithTag("T_Fade3").GetComponent<Fadeing3>();

        audioController = GameObject.FindGameObjectWithTag("T_Sound").GetComponent<AudioController>();
    }

    void OnTriggerStay(Collider other)
    {
        tut1.SetActive(false);
        tut2.SetActive(false);
        hiddenGoal1.SetActive(true);

        if (challenge1Done == false)
        {
            hiddenCover1.SetActive(true);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                hiddenTip.SetActive(true);
                hiddenFloatingClue1.SetActive(true);    //D
                hiddenFloatingClue2.SetActive(true);    //E 
                hiddenFloatingClue3.SetActive(true);    //L
                hiddenFloatingClue4.SetActive(true);    //E
                hiddenFloatingClue5.SetActive(true);    //T
                hiddenFloatingClue6.SetActive(true);    //E

                audioController.playDing();
                fadeing.fadeUp1();
                fadeing2.fadeUp2();

                print("Challenge1 Done");
                hiddenCover1.SetActive(false);
                challenge1Done = true;
            }
        }

        hiddenCover2.SetActive(true);

        if (challenge1Done == true)
        {
            titleAlphabet.SetActive(false);
            titleCode.SetActive(false);
            hiddenTip.SetActive(true);
            hiddenFloatingClue1.SetActive(true);
            hiddenFloatingClue2.SetActive(true);
            hiddenFloatingClue3.SetActive(true);
            hiddenFloatingClue4.SetActive(true);
            hiddenFloatingClue5.SetActive(true);
            hiddenFloatingClue6.SetActive(true);

            if (challenge2Done == false)
            {
                if (Input.GetKeyDown(KeyCode.Delete)|| Input.GetKeyDown(KeyCode.Backspace))
                {
                    audioController.playDing();
                    fadeing3.fadeDelete();

                    print("Challenge2 Done");
                    hiddenCover2.transform.Translate(0, -100, 0);
                    challenge2Done = true;
                }
            }
        }
    }

    void OnTriggerExit (Collider other)
    {
        hiddenGoal1.SetActive(false);

        if (challenge1Done == true)
        {
            hiddenTip.SetActive(false);
            hiddenFloatingClue1.SetActive(false);
            hiddenFloatingClue2.SetActive(false);
            hiddenFloatingClue3.SetActive(false);
            hiddenFloatingClue4.SetActive(false);
            hiddenFloatingClue5.SetActive(false);
            hiddenFloatingClue6.SetActive(false);
        }

        hiddenCover1.SetActive(false);
        hiddenCover2.SetActive(false);
        hiddenTip.SetActive(false);
    }
}
