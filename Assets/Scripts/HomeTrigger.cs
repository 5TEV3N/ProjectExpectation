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

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            hiddenClue4.SetActive(true);
            hiddenClue5.SetActive(true);
            print("Challenge1 Done");
            Destroy(hiddenClue2);
        }
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            Destroy(hiddenClue3);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        title.SetActive(false);
        tut.SetActive(false);

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
