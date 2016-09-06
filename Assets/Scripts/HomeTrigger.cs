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
    public GameObject hiddenClue5;
    Collider other;

    Fadeing fadeing;
    AudioController audioController;

    void Awake()
    {
        fadeing = GameObject.FindGameObjectWithTag("T_Fade").GetComponent<Fadeing>();
        audioController = GameObject.FindGameObjectWithTag("T_Sound").GetComponent<AudioController>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Delete)) // change : Destroy to fadeing
        {
            fadeing.fadeDelete();
            Destroy(hiddenClue3);
            audioController.playDing();
        }
    }

    void OnTriggerStay(Collider other)
    {
        title.SetActive(false);
        tut.SetActive(false);

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            hiddenClue4.SetActive(true);
            hiddenClue5.SetActive(true);

            audioController.playDing();
            fadeing.fadeUp();

            print("Challenge1 Done");
            Destroy(hiddenClue2);
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
