using UnityEngine;
using System.Collections;

public class HomeTrigger : MonoBehaviour
{
    public GameObject title;
    public GameObject tut;

    public GameObject hiddenClue1;
    public GameObject hiddenClue2;
    public GameObject hiddenClue3;
    public GameObject hiddenClue4;

    public GameObject hiddenFloatingClue1;
    public GameObject hiddenFloatingClue2;
    public GameObject hiddenFloatingClue3;
    public GameObject hiddenFloatingClue4;
    public GameObject hiddenFloatingClue5;
    public GameObject hiddenFloatingClue6;

    public bool challenge1Done = false;
    public bool challenge2Done = false;

    Fadeing fadeing;
    AudioController audioController;

    void Awake()
    {
        fadeing = GameObject.FindGameObjectWithTag("T_Fade").GetComponent<Fadeing>();

        audioController = GameObject.FindGameObjectWithTag("T_Sound").GetComponent<AudioController>();
    }

    void Update()
    {
        if (challenge1Done == true)
        {
            if (challenge2Done == false)
            {
                if (Input.GetKeyUp(KeyCode.Delete))
                {
                    Destroy(hiddenClue3);
                    audioController.playDing();

                    challenge2Done = true;
                }
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        title.SetActive(false);
        tut.SetActive(false);

        if (challenge1Done == false)
        {
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                hiddenClue4.SetActive(true);

                audioController.playDing();
                fadeing.fadeUp();

                print("Challenge1 Done");
                Destroy(hiddenClue2);

                //fadeing2.Visible(); enable the hidden floating clues here

                challenge1Done = true;
            }
        }

        hiddenClue1.SetActive(true);
        hiddenClue2.SetActive(true);
        hiddenClue3.SetActive(true);
    }

    void OnTriggerExit (Collider other)
    {
        hiddenClue1.SetActive(false);
        hiddenClue2.SetActive(false);
        hiddenClue3.SetActive(false);
        hiddenClue4.SetActive(false);
    }
}
