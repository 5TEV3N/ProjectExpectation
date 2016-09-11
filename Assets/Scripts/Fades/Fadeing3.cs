using UnityEngine;
using System.Collections;

public class Fadeing3 : MonoBehaviour
{
    public Animator animator;

    void Awake()
    {
        animator = GameObject.FindGameObjectWithTag("T_Fade3").GetComponent<Animator>();
    }

    public void fadeDelete()
    {
        animator.SetBool("deleteKeyPressed", true);
    }
}
