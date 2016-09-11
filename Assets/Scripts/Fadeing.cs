using UnityEngine;
using System.Collections;

public class Fadeing : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        animator = GameObject.FindGameObjectWithTag("T_Fade").GetComponent<Animator>();
        //animator = gameObject.GetComponent<Animator>();   
    }

    public void fadeUp1()
    {
        animator.SetBool("upKeyPressed", true);
    }

    public void fadeUp2()
    {
        animator.SetBool("upKeyPressed2", true);
    }
}
