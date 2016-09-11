using UnityEngine;
using System.Collections;

public class Fadeing2 : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        animator = GameObject.FindGameObjectWithTag("T_Fade2").GetComponent<Animator>();
        //animator = gameObject.GetComponent<Animator>();   
    }

    public void fadeUp2()
    {
        animator.SetBool("upKeyPressed2", true);
    }
}
