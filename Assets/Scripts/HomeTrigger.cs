using UnityEngine;
using System.Collections;

public class HomeTrigger : MonoBehaviour
{
    public GameObject title;
    public GameObject tut;

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
    AudioController audioController;

    void Awake()
    {
        fadeing = GameObject.FindGameObjectWithTag("T_Fade").GetComponent<Fadeing>();

        audioController = GameObject.FindGameObjectWithTag("T_Sound").GetComponent<AudioController>();
    }

    void OnTriggerStay(Collider other)
    {
        title.SetActive(false);
        tut.SetActive(false);
        hiddenGoal1.SetActive(true);

        if (challenge1Done == false)
        {
            hiddenCover1.SetActive(true);
            if (Input.GetKeyUp(KeyCode.UpArrow))
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
                fadeing.fadeUp2();

                print("Challenge1 Done");
                hiddenCover1.SetActive(false);
                challenge1Done = true;
            }
        }

        hiddenCover2.SetActive(true);

        if (challenge1Done == true)
        {
            hiddenFloatingClue1.SetActive(true);
            hiddenFloatingClue2.SetActive(true);
            hiddenFloatingClue3.SetActive(true);
            hiddenFloatingClue4.SetActive(true);
            hiddenFloatingClue5.SetActive(true);
            hiddenFloatingClue6.SetActive(true);

            if (challenge2Done == false)
            {
                if (Input.GetKeyUp(KeyCode.Delete))
                {
                    //hiddenCover2.SetActive(false);
                    hiddenCover2.transform.Translate(0, -100, 0);
                    audioController.playDing();

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
